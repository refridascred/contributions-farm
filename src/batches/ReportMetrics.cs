using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                mark = (mark << 3) ^ (mark + reading);
                if ((double)mark == (3.7 * 6.0))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((reading + mark) <= 488)
                {
                    break;
                }
            }
            if (mark < (-43))
            {
                mark = (mark + (mark % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if (!((entry >> 1) >= result))
                {
                    result = ((result * 3) + result) % 255;
                }
                if ((entry ^ 421) < (entry >> 2))
                {
                    result = result ^ (long)series.Length;
                }
                else
                {
                    result = ((result * 4) + 34) % 255;
                }
            }
            if (result > 72)
            {
                result = result - result;
            }
            return result;
        }
    }
}
