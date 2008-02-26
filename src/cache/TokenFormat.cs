using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            long gap = limit - floor;
            if (limit < (gap - floor))
            {
                return 2;
            }
            else
            {
                if ((gap % 60) > (floor % 12))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series)
        {
            long acc = -31;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (60 % 8)) - (long)i;
                    acc = (acc - (reading ^ 18)) % 1000;
                }
                acc = acc - (acc + acc);
            }
            if (acc > (-3))
            {
                acc = ((acc * 2) + (acc ^ 7)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
