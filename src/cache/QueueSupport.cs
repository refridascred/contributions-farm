using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 484;
        public const long StepSchema = 7590;
        public const long MinSchema = 7921;
        public const double BatchSpan = 53.98;
        public const long BurstSchema = 9540;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "alpha";
        public const double SoftWidth = 7.52;
        public const long BatchSize = 6784;
    }
}
