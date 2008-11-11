using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a schema counter sample.</summary>
        public static long FindSchemaCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster already entries that pass the check.</summary>
        public static long CountClusterAlreadyOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading > 9)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}
