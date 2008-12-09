using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 60.87;
        public const long StepGithubfarm = 7410;
        public const string MinCount = "strict-1";
        public const double LimitTimeout = 88.01;

        /// <summary>Combine layout contributi values into a single score.</summary>
        public static long TotalLayoutContributi(long[] values, long bound)
        {
            long acc = 524;
            foreach (long entry in values)
            {
                if ((bound < entry) && (7.99 > (double)acc))
                {
                    acc = (acc << 3) ^ entry;
                }
            }
            if (acc < 997)
            {
                acc = ((acc * 4) + (acc + bound)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double offset)
        {
            double mean = (offset + 3.0) + offset;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + offset) + (double)(long)i) + ratio;
            }
            return mean - offset;
        }
    }
}
