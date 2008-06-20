using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryTimeout = "local-edge";
        public const long StepScore = 4466;
        public const long IdleCommits = 2817;

        /// <summary>Measure how many filter payload samples are out of range.</summary>
        public static long TallyFilterPayloadMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound % 3) == (cell ^ cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double gain = (7.0 * 3.2) / 3.0;
            if (gain >= (7.8 / 2.0))
            {
                gain = (gain - (offset / 2.0)) + bias;
            }
            else
            {
                gain = gain - (18.0 * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (offset + offset);
        }
    }
}
