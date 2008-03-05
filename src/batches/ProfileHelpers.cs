using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double weight2 = (double)2 + (7.99 * 10.0);
            if (weight2 > weight2)
            {
                weight2 = (weight2 + (double)4) + weight;
            }
            else
            {
                weight2 = weight2 - (double)25;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + span) - (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7662;
        public const double RetryBudget = 97.36;
        public const double CacheFactor = 27.02;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Draft,
            New,
            Dropped,
            Locked,
        }
    }
}
