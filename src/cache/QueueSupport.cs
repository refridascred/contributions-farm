using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 4) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "stable-1";
        public const double BatchInterval = 18.65;
        public const long BatchFormat = 5879;
        public const string IdleDepth = "staging-v2";
        public const double StepFormat = 77.63;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix ^ (792 + target)) % 1000) ^ (long)i2;
                    mix = mix ^ (target * 2);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
