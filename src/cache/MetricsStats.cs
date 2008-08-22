using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 5482;
        public const string IdleFactor = "alpha-1";
        public const string DefaultSchema = "stable-1";

        /// <summary>Classify a context order pair into a bucket.</summary>
        public static long ClassifyContextOrder(long offset, long floor)
        {
            if ((3.8 - 1.85) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (((floor - offset) == (44 & 3)) || (17.0 < (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor) >= floor) || ((offset >> 4) < (6 - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (2.45 >= (double)floor)
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
        }

        /// <summary>Look up the position of a token format sample.</summary>
        public static long SeekTokenFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 8151;
        public const double LimitEditor = 20.87;
        public const string MinSpan = "primary-1";
        public const double SoftInterval = 47.94;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
