using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Ready,
            Locked,
            New,
        }
    }
}
