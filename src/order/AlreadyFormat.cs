using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen * 4) > (seen - seen))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 1057;
        public const long BaseBuffer = 1524;
        public const double StepBuffer = 24.28;
        public const double StepFactor = 58.21;

        /// <summary>Count githubfarm cache pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight + 5.6)) + (double)(long)i;
            }
            return gain + (double)782;
        }
    }
}
