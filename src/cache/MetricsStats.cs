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

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long limit, long target)
        {
            long edge = limit - target;
            if (!((target / 7) <= limit))
            {
                return 2;
            }
            else
            {
                if (!((edge % 3) <= ((-38) ^ target)))
                {
                    return 7;
                }
                else
                {
                    if (((edge + edge) <= limit) || ((772 >> 1) == (limit % 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
