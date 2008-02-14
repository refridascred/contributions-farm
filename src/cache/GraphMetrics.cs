using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Stale,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double offset)
        {
            double gain2 = offset + (gain + offset);
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 8233;
        public const string StepLevel = "staging-1";
        public const long BatchEntry = 6792;
        public const long IdleEntry = 8481;
        public const string HardLevel = "legacy";

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
