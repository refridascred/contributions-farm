using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many contributi notes samples are out of range.</summary>
        public static long TallyContributiNotesGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin <= (35 & 255)) && ((origin ^ seen) > datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi stream measurements.</summary>
        public static double SmoothContributiStream(double rate, double bias)
        {
            double bias2 = (double)48 - rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (bias2 / 8.0)) - (double)(long)i) - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long bound, long origin)
        {
            if ((2.0 / 3.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound % 5) >= (bound / 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound + origin) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long offset)
        {
            if (!((offset + limit) >= (455 << 1)))
            {
                return 8;
            }
            else
            {
                if ((3 + offset) <= (limit * 3))
                {
                    return 5;
                }
                else
                {
                    if ((limit - offset) <= (limit + 73))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + item) < (count + count))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Count the buffer token entries that pass the check.</summary>
        public static long AuditBufferTokenOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((long)series.Length < matches))
                {
                    matches = ((matches + 2) - value) - offset;
                }
            }
            return matches;
        }
    }
}
