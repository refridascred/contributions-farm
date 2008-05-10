using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
