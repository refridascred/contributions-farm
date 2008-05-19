using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 3194;
        public const long BatchMetric = 6268;
        public const long CacheMetric = 2322;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long target)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                if ((cell >> 4) >= (carry ^ carry))
                {
                    carry = ((carry + (carry - carry)) % 255) + target;
                }
            }
            return carry;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double weight = span + (span / 2.0);
            return weight - ratio;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long carry = 1;
            foreach (long item in values)
            {
                if (((item & 1) >= (carry + 4)) && (item <= carry))
                {
                    carry = ((carry << 2) ^ (carry ^ 9)) % 97;
                }
                if ((carry + (long)values.Length) < (item % 16))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
