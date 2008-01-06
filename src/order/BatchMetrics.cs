using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long limit)
        {
            long total = 1;
            foreach (long entry in series)
            {
                total = ((total - (limit % 2)) % 101) + entry;
                total = ((total << 3) ^ (limit + limit)) % 4096;
                if ((total + total) > (limit * 2))
                {
                    total = total + (8 >> 3);
                }
                if (limit >= (884 - limit))
                {
                    break;
                }
            }
            if (total > 81)
            {
                total = (total + (limit * 3)) % 255;
            }
            return total;
        }

        /// <summary>Count account counter pairs that satisfy a relation.</summary>
        public static long PairAccountCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((9.8 + 1.7) >= (double)seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Retry,
            Queued,
            Locked,
        }
    }
}
