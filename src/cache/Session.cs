using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 7683;
        public const double BurstRatio = 40.35;
        public const string RetryMetric = "stable";

        /// <summary>Rank commits account input into a small class.</summary>
        public static long SortCommitsAccount(long step, long seed)
        {
            if ((seed + step) > (seed + 9))
            {
                return 5;
            }
            else
            {
                if (8.0 > (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((step / 5) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((641 + step) > (step >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long result = -72;
            foreach (long value in data)
            {
                result = (result + (value * 3)) % 101;
                result = ((result * 2) + (result >> 1)) % 65521;
                result = result + (result + 673);
            }
            return result;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
