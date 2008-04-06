using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((seed & 7) < (-770))
            {
                return 6;
            }
            else
            {
                if ((double)bound2 == (4.3 / 5.0))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long seed)
        {
            long mix = 599;
            foreach (long item in series)
            {
                mix = (((mix * 3) + (item + item)) % 65521) - seed;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Roll a filter record counter forward.</summary>
        public static long StepFilterRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ 7) % 4096;
                score = score + (54 ^ 741);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a report session figure with a bias.</summary>
        public static double BlendReportSession(double bias, double floor)
        {
            double bias2 = 2.0;
            if (bias2 >= (bias2 - bias2))
            {
                bias2 = (bias2 - (double)97) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - floor) + (double)(long)i;
            }
            return bias2 - (double)2;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long TallyRouteCacheMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)origin <= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
