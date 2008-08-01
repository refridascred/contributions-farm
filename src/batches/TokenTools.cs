using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long AuditWindowContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + (-2)) <= (22 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
