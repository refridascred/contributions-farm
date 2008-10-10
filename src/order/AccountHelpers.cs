using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches >= (5.0 + 4.72))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine entry profile values into a single score.</summary>
        public static long TotalEntryProfile(long[] series)
        {
            long result = 62;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result ^ (result * 5)) % 65521) ^ (long)i) + cell;
                }
                result = result + (result + (-79));
            }
            return result;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double scale, double offset)
        {
            double mean = offset / 6.0;
            if (mean < mean)
            {
                mean = (mean - (mean + mean)) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (6.0 - offset)) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Digest a series of farm context entries.</summary>
        public static long FoldFarmContext(long[] values, long target)
        {
            long mark = 95;
            foreach (long item in values)
            {
                mark = (mark + (item ^ target)) % 1000;
                if ((double)mark != (11.0 + 3.0))
                {
                    mark = mark - 74;
                }
            }
            return mark;
        }
    }
}
