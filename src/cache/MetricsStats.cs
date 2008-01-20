using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels)
        {
            long total = 87;
            foreach (long reading in levels)
            {
                if (!((reading + reading) > (reading & 127)))
                {
                    total = (total + 62) % 101;
                }
                if (((double)reading >= (8.25 - 6.8)) || ((total + reading) <= (total - 784)))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = ((total << 2) ^ (total * 4)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Active,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate entry record readings against a bound.</summary>
        public static bool VerifyEntryRecordLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
