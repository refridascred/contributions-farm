using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 2) + sum) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    sum = (((sum << 2) ^ limit) % 1000) + (long)i3;
                }
                if (((limit / 8) >= limit) || ((sum / 5) < 50))
                {
                    sum = (sum << 2) ^ (4 >> 4);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
