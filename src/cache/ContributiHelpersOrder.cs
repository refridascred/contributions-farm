using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two buffer payload measurements.</summary>
        public static double SmoothBufferPayload(double gain, double offset)
        {
            double gain2 = (double)5 - offset;
            return gain2 + gain;
        }

        /// <summary>Count entry stats pairs that satisfy a relation.</summary>
        public static long OverlapEntryStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
