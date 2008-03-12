using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long origin)
        {
            long step = bound + origin;
            if ((origin << 1) < bound)
            {
                return 5;
            }
            else
            {
                if ((bound >> 5) < (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((step >> 1) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings)
        {
            long state = 678;
            foreach (long reading in readings)
            {
                if ((2 - reading) <= reading)
                {
                    state = ((state * 2) + state) % 1000;
                    continue;
                }
                if ((state <= 9) || ((double)state == (5.4 * 1.3)))
                {
                    state = state ^ (state >> 3);
                }
            }
            return state;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double rate = 5.8 - (weight + weight);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (weight * 3.62);
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = ((state * 4) + (bound * 4)) + (long)i3;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
