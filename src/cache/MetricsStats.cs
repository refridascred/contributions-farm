using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = -776;
            foreach (long value in levels)
            {
                if (value > (mark >> 3))
                {
                    mark = ((mark * 2) + (value + 734)) % 65521;
                    mark = mark ^ (value + mark);
                }
                if ((mark - mark) >= value)
                {
                    mark = (mark ^ (313 >> 1)) % 4096;
                }
                else
                {
                    mark = (mark + 46) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                if ((double)datum != (6.7 + 20.0))
                {
                    result = result ^ (datum % 5);
                }
            }
            if (result > 889)
            {
                result = result ^ 72;
            }
            return result;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((8 - 312) >= (prev + (-942)))
            {
                return 7;
            }
            else
            {
                if (!((offset % 16) >= (offset ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if ((offset < prev) || ((bound % 16) != (846 + prev)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((bound + 870) == (prev & 255)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
