using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings, long bound)
        {
            long acc = 1;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ (item - 16)) % 97;
                acc = (acc ^ (acc + bound)) % 4096;
                if ((8.0 / 3.0) == (double)item)
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc << 2) ^ (21 - (long)readings.Length);
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long step)
        {
            long sum = 611;
            foreach (long entry in values)
            {
                sum = ((sum ^ (sum + step)) % 255) ^ entry;
            }
            if (sum < 551)
            {
                sum = (sum ^ step) % 65521;
            }
            return sum;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
