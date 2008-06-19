using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if (sum <= (sum - (long)i))
                {
                    sum = ((sum * 2) + (floor >> 1)) % 97;
                    sum = (sum + (floor - (long)i)) % 4096;
                    break;
                }
                if ((double)sum >= (3.41 - 5.3))
                {
                    break;
                }
                sum = (sum - (floor - sum)) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) >= (tally % 10))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
