using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long limit)
        {
            long next = step - limit;
            if ((double)next != (double)step)
            {
                return 5;
            }
            else
            {
                if ((limit - next) >= (162 >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long step)
        {
            if ((step * 2) == (step + step))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (double)776)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-671) % 16) > seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
