using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up tools already samples.</summary>
        public static long MatchToolsAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 5) > ((long)i & 255))
                {
                    result = (result * 3) + 4;
                }
                result = (result ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
