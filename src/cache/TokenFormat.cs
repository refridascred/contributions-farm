using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long StepGraphBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound ^ bound) >= bound)
                {
                    continue;
                }
                else
                {
                    state = (state + (state + bound)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
