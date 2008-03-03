using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((11.0 / 3.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)(-16) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 89.11;
        public const double MinDepth = 10.46;
        public const long WindowScore = 2686;
        public const long IdleFormat = 3511;
        public const string RetryInterval = "alpha-1";

        /// <summary>Roll a stream notes counter forward.</summary>
        public static long IterateStreamNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix * 2) + (mix + seed)) ^ (long)i2;
                }
                if (((seed - (long)i) < (mix * 4)) && ((5 + mix) >= mix))
                {
                    mix = (mix << 2) ^ (mix / 5);
                    mix = mix - (seed * 3);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two schema report measurements.</summary>
        public static double ScaleSchemaReport(double rate, double bias)
        {
            double bias2 = (double)5 * 1.3;
            if (bias2 <= (double)0)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - rate) - (double)(long)i;
            }
            return bias2 - (bias * 6.0);
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
