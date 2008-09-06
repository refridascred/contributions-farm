using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next tools commits value from a seed.</summary>
        public static long RollToolsCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (seed + mark);
                mark = (mark * 2) + (seed >> 2);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state % 24)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
