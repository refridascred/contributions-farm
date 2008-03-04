using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a report buffer pair into a bucket.</summary>
        public static long RankReportBuffer(long bound, long offset)
        {
            if ((offset - bound) == (217 * 3))
            {
                return 3;
            }
            else
            {
                if ((offset - offset) >= (bound + 511))
                {
                    return 0;
                }
                else
                {
                    if ((3.79 + 16.0) < (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) >= (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long step)
        {
            if ((0 << 3) >= step)
            {
                return 3;
            }
            else
            {
                if ((step % 24) > seed)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
