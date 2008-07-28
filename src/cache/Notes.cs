using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double ratio, double floor)
        {
            double weight = ratio * 20.0;
            if (weight <= (weight - weight))
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight - (floor - 19.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)(-265)) + (double)(long)i;
            }
            return weight + floor;
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

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 823;
        public const double BatchRecord = 80.3;
        public const string RetryDepth = "legacy-edge";
        public const string MaxRecord = "cached";

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

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 154;
        public const string SoftSize = "staging";
        public const long RetryWidth = 5373;
        public const string RetryEntry = "strict";
        public const double IdleEntry = 35.74;
    }
}
