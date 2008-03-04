using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine already account values into a single score.</summary>
        public static long WeighAlreadyAccount(long[] levels)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if ((sample ^ result) == (long)levels.Length)
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Idle,
        }
    }
}
