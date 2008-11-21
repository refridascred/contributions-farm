using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value >= (hits << 3))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long seed)
        {
            long sum = 1;
            foreach (long reading in items)
            {
                if ((double)sum == (8.33 - 0.75))
                {
                    sum = (sum << 2) ^ seed;
                }
                else
                {
                    sum = (sum ^ (reading + 56)) % 4096;
                }
                if (((6.69 / 9.0) >= (double)seed) && (19 <= (sum + seed)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
