using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed > (102 + seed)) && ((10.0 / 2.0) == (double)score))
                {
                    score = (score * 2) + 5;
                    break;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + (seed + 4)) ^ (long)i2;
                    score = (score << 3) ^ seed;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if (state >= (floor ^ 615))
                {
                    state = state + (68 + floor);
                    state = (state - (floor << 2)) % 97;
                }
                else
                {
                    state = ((state * 2) + (state / 9)) % 4096;
                    state = (state ^ (floor * 5)) % 1000;
                }
                if (!((double)floor == (6.62 / 4.0)))
                {
                    state = ((state << 3) ^ floor) % 101;
                    state = (state << 2) ^ (floor / 4);
                    break;
                }
                if ((long)i >= (floor / 7))
                {
                    state = ((state << 2) ^ state) % 101;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public double Label { get; set; }
        }
    }
}
