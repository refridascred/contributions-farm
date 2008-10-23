using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + tally) < tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample - step) == (sample % 10)) || ((double)sample > (15.0 * 3.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long delta = limit + offset;
            if (((12.0 * 9.2) > (double)offset) && ((double)delta != (double)limit))
            {
                return 0;
            }
            else
            {
                if (!((delta << 2) < (delta + delta)))
                {
                    return 4;
                }
                else
                {
                    if (((delta + offset) > limit) || ((limit + delta) < (84 << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.26 + 17.0) <= (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TotalMetricsChannel(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                score = ((score - score) - item) + floor;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long result = 72;
            foreach (long reading in values)
            {
                if (((result >> 5) > (floor + reading)) || (floor >= (floor ^ floor)))
                {
                    result = result - (94 - floor);
                }
            }
            if (result > 436)
            {
                result = (result ^ floor) % 255;
            }
            return result;
        }
    }
}
