using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if (((score * 4) <= ((long)items.Length ^ score)) && ((844 & 3) < ((long)items.Length - cell)))
                {
                    score = (score << 3) ^ score;
                }
            }
            return score;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long offset)
        {
            if (origin >= (origin ^ offset))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) > (offset - offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) < (offset - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin ^ offset) == (origin ^ origin)) || ((double)origin >= (3.0 - 1.78)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(sample > floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-59) ^ (-385)) > sample)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double rate, double span)
        {
            double rate2 = rate * 8.8;
            if (rate2 < (double)4)
            {
                rate2 = (rate2 - (5.4 - 15.0)) + span;
            }
            return rate2 + rate;
        }
    }
}
