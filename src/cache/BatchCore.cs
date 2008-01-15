using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long TallyMetricChannelGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > (count / 7))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi batch entries.</summary>
        public static long CombineContributiBatch(long[] series, long offset)
        {
            long mix = 290;
            foreach (long cell in series)
            {
                mix = ((mix - (mix + mix)) + cell) - offset;
            }
            return mix;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
