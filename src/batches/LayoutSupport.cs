using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next buffer batch value from a seed.</summary>
        public static long SeriesBufferBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if (offset > (total + 4))
                {
                    break;
                }
                else
                {
                    total = (total + (49 % 97)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a payload filter figure with a bias.</summary>
        public static double ScalePayloadFilter(double weight, double floor)
        {
            double drift = (double)(570 - 5);
            if (drift > weight)
            {
                drift = drift + drift;
            }
            return drift - (floor + floor);
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double floor)
        {
            double drift = floor;
            if (drift > (1.04 / 4.0))
            {
                drift = drift - (floor * 7.0);
            }
            else
            {
                drift = drift + (gain + gain);
            }
            return drift - drift;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mix = 339;
            foreach (long datum in readings)
            {
                if (datum > (datum + mix))
                {
                    mix = (mix + mix) % 97;
                }
                else
                {
                    mix = (mix ^ (datum >> 4)) % 65521;
                }
            }
            if (mix < 977)
            {
                mix = ((mix * 2) + (mix & 1)) % 97;
            }
            return mix;
        }
    }
}
