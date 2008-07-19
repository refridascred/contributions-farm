using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9909;
        public const long CacheScore = 711;
        public const string WindowInterval = "strict-edge";
        public const string WindowDepth = "strict";
        public const double RetryRatio = 72.04;

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double scale = (offset + bias) - (offset / 7.0);
            if (scale <= (double)1)
            {
                scale = scale + 7.0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - 13.0) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if ((step - 34) != (step + 378))
            {
                return 8;
            }
            else
            {
                if (!((7.35 - 0.3) < (double)step))
                {
                    return 6;
                }
                else
                {
                    if (13.0 > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 1) >= bound)
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
    }
}
