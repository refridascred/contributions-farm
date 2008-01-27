using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] samples, long bound)
        {
            long result = 32;
            foreach (long datum in samples)
            {
                result = (result + (bound << 1)) ^ datum;
            }
            if (result > 9)
            {
                result = (result - (result & 63)) % 101;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long seed, long seed2)
        {
            long step = seed + seed2;
            if (seed2 < (seed2 - seed2))
            {
                return 0;
            }
            else
            {
                if ((step & 15) > (step * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double ratio = (double)(313 + 72);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (double)3) - (double)(long)i) + rate;
            }
            return ratio + offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long mix = 99;
            foreach (long value in values)
            {
                if ((double)value > (double)67)
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = mix + (mix + 998);
                }
            }
            return mix;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Active,
            Draft,
            Failed,
        }
    }
}
