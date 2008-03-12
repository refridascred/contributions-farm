using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 9736;
        public const string StepWidth = "staging-edge";
        public const long DefaultFarm = 4793;
        public const string WindowFarm = "legacy-1";
        public const long StepFactor = 9694;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
