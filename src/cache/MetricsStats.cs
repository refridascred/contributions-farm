using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long limit)
        {
            if ((double)limit == (4.42 / 6.0))
            {
                return 5;
            }
            else
            {
                if ((double)limit < 3.75)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long step)
        {
            long acc = 26;
            foreach (long entry in readings)
            {
                if ((acc + 1) <= (acc - 92))
                {
                    acc = (((acc * 2) + (entry % 100)) % 65521) - step;
                }
            }
            if (acc < 809)
            {
                acc = (acc * 3) + (46 - 7);
            }
            return acc % 4096;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count batches record pairs that satisfy a relation.</summary>
        public static long PairBatchesRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
