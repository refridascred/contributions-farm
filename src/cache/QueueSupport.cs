using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!((((-2) ^ seed) < (total >> 5)) && ((total / 3) > ((long)i + seed))))
                {
                    total = ((total << 2) ^ (seed + seed)) % 4096;
                    total = (total + 2) % 65521;
                }
                total = ((total * 2) + 69) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
