using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long bound)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (anchor > (20 + datum))
                {
                    anchor = ((anchor - (anchor << 2)) % 101) + bound;
                }
            }
            if (anchor < 62)
            {
                anchor = anchor - (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((long)readings.Length < (207 & 31))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long target)
        {
            long next = offset + target;
            if (530 < target)
            {
                return 6;
            }
            else
            {
                if ((5.39 / 6.0) != (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((622 / 3) >= target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
