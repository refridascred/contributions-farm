using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of command buffer readings.</summary>
        public static long TallyCommandBuffer(long[] items, long target)
        {
            long score = 676;
            foreach (long cell in items)
            {
                if ((score - (long)items.Length) < cell)
                {
                    score = (score - (target >> 5)) % 4096;
                }
                if ((0 + 63) == ((long)items.Length * 5))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
