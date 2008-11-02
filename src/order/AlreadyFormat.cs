using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Dropped,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Match up tools already samples.</summary>
        public static long OverlapToolsAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWidth = 20.17;
        public const string DefaultWindow = "staging-1";
        public const string BaseInterval = "open";

        /// <summary>Scale a schema route figure with a bias.</summary>
        public static double AdjustSchemaRoute(double gain, double offset)
        {
            double drift = gain;
            if (drift < offset)
            {
                drift = drift + (gain + 0.5);
            }
            return drift + (4.0 + drift);
        }
    }
}
