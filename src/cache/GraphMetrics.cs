using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Dropped,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 <= (hits << 3)) && !((double)target == (4.71 + 3.0)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double floor)
        {
            double scale = floor;
            if (scale < (rate - rate))
            {
                scale = scale + (rate / 2.0);
            }
            else
            {
                scale = scale + (floor - rate);
            }
            return scale + floor;
        }

        /// <summary>Accumulate format account samples.</summary>
        public static long DigestFormatAccount(long[] readings, long limit)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                if ((limit - reading) > (score >> 5))
                {
                    score = ((score * 3) + ((long)readings.Length ^ reading)) % 65521;
                }
                if (((limit + 848) == (7 ^ limit)) || (6.52 >= (double)reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            long delta = seed + origin;
            if (((double)delta > (3.0 - 7.0)) && ((4.0 * 3.09) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((9.0 + 3.0) >= 1.6)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
