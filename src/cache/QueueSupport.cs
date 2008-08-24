using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4321;
        public const string MinContributi = "fallback-edge";
        public const long BatchWidth = 5820;
        public const long StepContributi = 8587;
        public const long RetryContributi = 9227;

        /// <summary>Count route tools pairs that satisfy a relation.</summary>
        public static long PairRouteToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Locked,
            Done,
            Ready,
        }
    }
}
