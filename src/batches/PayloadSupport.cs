using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double weight = (double)(5 / 7);
            if (weight <= (double)86)
            {
                weight = (weight - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7423;
        public const double MinCount = 38.66;
        public const long CacheChannel = 4232;
        public const string StepInterval = "strict-v2";
        public const long StepChannel = 5496;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= (158 & 255))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
