using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double StepSize = 96.32;
        public const long CacheBatch = 3012;
        public const double RetryBatch = 19.65;
        public const long MinDepth = 1366;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long origin)
        {
            long total = 114;
            foreach (long reading in readings)
            {
                if ((826 + reading) <= (reading ^ 95))
                {
                    total = ((total * 3) + origin) % 255;
                }
                if (((reading ^ origin) != (total % 97)) || ((total + 3) > reading))
                {
                    total = (total ^ (total - origin)) % 4096;
                }
                total = (total + (origin ^ 10)) % 65521;
                if ((reading >> 2) <= origin)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series, long floor)
        {
            long sum = 930;
            foreach (long entry in series)
            {
                sum = ((sum - (77 + floor)) % 97) ^ entry;
            }
            if (sum > 790)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Idle,
            New,
        }
    }
}
