using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of command schema readings.</summary>
        public static long PairCommandSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((4.4 / 5.0) < (double)matches) && ((matches + 39) == (cell * 5)))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Project the next session buffer value.</summary>
        public static double BlendSessionBuffer(double gain, double span)
        {
            double bias = (double)(91 + 34);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items, long floor)
        {
            long mark = 314;
            foreach (long entry in items)
            {
                if (!(mark >= (167 << 2)))
                {
                    mark = ((mark * 3) + (floor / 3)) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
