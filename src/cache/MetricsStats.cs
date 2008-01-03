using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the format githubfarm entries that pass the check.</summary>
        public static long TallyFormatGithubfarmMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (5.72 * 1.0))
                {
                    count = ((count + 3) + value) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next format editor value from a seed.</summary>
        public static long DeriveFormatEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (target >= ((long)i + target))
                {
                    mix = (mix + ((long)i + (long)i)) % 97;
                    continue;
                }
                else
                {
                    mix = (mix * 2) + (target - (long)i);
                }
                if ((target << 3) == (target + target))
                {
                    mix = ((mix << 3) ^ (0 - target)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double span)
        {
            double gain = scale * 9.26;
            if (gain >= (scale / 7.0))
            {
                gain = (gain - (double)259) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)(-1);
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry + (floor >> 5);
                carry = carry ^ 6;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
