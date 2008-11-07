using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double mean = bias * 8.8;
            if (mean < (double)(-8))
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean + (gain - mean);
            }
            return mean + mean;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((4 % 12) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long offset)
        {
            long span = target + offset;
            if ((4.9 + 12.0) != (double)target)
            {
                return 0;
            }
            else
            {
                if (((offset + offset) >= (span * 2)) || ((offset + span) < (span + 0)))
                {
                    return 5;
                }
                else
                {
                    if ((target - offset) >= (offset - 840))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)target == (6.1 - 20.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin % 10) < (origin - origin))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
