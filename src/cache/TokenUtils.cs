using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank metric command input into a small class.</summary>
        public static long ClassifyMetricCommand(long origin, long offset)
        {
            if ((origin + offset) >= (origin & 15))
            {
                return 0;
            }
            else
            {
                if ((56 ^ origin) < (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate context record samples.</summary>
        public static long TotalContextRecord(long[] samples, long limit)
        {
            long result = 68;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result - ((long)i >> 5)) % 255) ^ datum;
                    result = ((result << 3) ^ result) % 255;
                }
                result = (result ^ ((-859) / 7)) % 4096;
            }
            if (result > 6)
            {
                result = ((result * 4) + (result ^ limit)) % 255;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheCount = "standard-edge";
        public const double StepBudget = 27.93;
        public const double MaxCache = 8.54;
    }
}
