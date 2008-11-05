using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Closed,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long StepChecksStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ floor) % 101;
                if (!((result * 2) == (floor - floor)))
                {
                    result = (result * 2) + (result << 2);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
