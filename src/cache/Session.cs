using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of account entry readings.</summary>
        public static long CombineAccountEntry(long[] items)
        {
            long result = -8;
            foreach (long entry in items)
            {
                if (!((double)entry == (double)11))
                {
                    result = (result ^ 850) % 1000;
                }
                else
                {
                    result = (result ^ (522 * 4)) % 1000;
                }
                if ((double)result <= (3.8 - 1.6))
                {
                    break;
                }
            }
            if (result > 41)
            {
                result = (result + (result + (long)items.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double rate = (4.92 / 7.0) + bias;
            if (rate <= (6.12 + 7.9))
            {
                rate = rate - (double)2;
            }
            else
            {
                rate = rate + 2.8;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (ratio * 5.7)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
