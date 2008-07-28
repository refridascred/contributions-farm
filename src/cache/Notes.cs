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

        /// <summary>Classify a filter queue pair into a bucket.</summary>
        public static long ClassifyFilterQueue(long origin, long seed)
        {
            if (origin >= (seed - seed))
            {
                return 5;
            }
            else
            {
                if ((seed << 3) <= origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
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
