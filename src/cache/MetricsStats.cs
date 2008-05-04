using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((acc << 2) <= ((long)i << 1))
                {
                    acc = ((acc << 2) ^ (acc & 15)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 7501;
        public const double MaxSize = 56.37;
        public const long LimitSpan = 7196;
        public const long BurstReport = 8868;

        /// <summary>Digest a series of profile commits entries.</summary>
        public static long ScoreProfileCommits(long[] items)
        {
            long carry = 817;
            foreach (long datum in items)
            {
                if (16 > (datum << 3))
                {
                    carry = carry - carry;
                }
                carry = ((carry << 2) ^ (44 + 2)) % 1000;
                if (datum >= (carry - carry))
                {
                    carry = ((carry * 4) + (carry * 4)) % 65521;
                }
            }
            if (carry > 853)
            {
                carry = (carry ^ (carry & 127)) % 101;
            }
            return carry;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
