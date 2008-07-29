using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long bound)
        {
            long result = 38;
            foreach (long value in levels)
            {
                if ((result > (result >> 4)) && (result >= (bound + 68)))
                {
                    result = ((result << 3) ^ (bound / 7)) + value;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long offset)
        {
            if ((offset << 1) < (origin * 4))
            {
                return 7;
            }
            else
            {
                if ((origin & 15) >= 2)
                {
                    return 1;
                }
                else
                {
                    if (((offset - offset) <= (-6)) && ((20.0 * 4.4) >= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin <= 3.22)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long MeasureQueueClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 1) != (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
