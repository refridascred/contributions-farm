using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double bias)
        {
            double rate = 11.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (17.0 - ratio)) + (double)(long)i) + bias;
            }
            return rate + 0.7;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if (!(4 >= (target + mix)))
                {
                    mix = ((mix * 3) + (target * 2)) % 101;
                }
                mix = (mix << 2) ^ (mix >> 2);
                mix = (mix - (mix << 1)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                if ((10.0 + 0.5) > (double)mark)
                {
                    mark = (mark + (entry + entry)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 9324;
        public const long StepStats = 9529;
        public const long BurstStats = 6997;
        public const long MinStats = 4006;
        public const long BaseStats = 3176;
    }
}
