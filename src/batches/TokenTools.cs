using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((step + 267) == (3 * 3)) || ((step << 2) <= (44 - tally)))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((result ^ result) <= (origin + result))
                {
                    result = (((result * 3) + result) % 65521) + sample;
                }
            }
            return result % 97;
        }
    }
}
