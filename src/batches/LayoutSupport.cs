using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
