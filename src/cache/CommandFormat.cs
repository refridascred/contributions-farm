using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool CheckLayoutGraphRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double mean = (floor + rate) * 9.1;
            if (mean <= (double)910)
            {
                mean = mean - (double)433;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - 16.0;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (sum % 100)) % 255;
                sum = ((sum * 5) + ((long)i * 5)) % 255;
                sum = (sum << 2) ^ ((-33) & 31);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
