using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long bound)
        {
            if (!((double)bound <= (double)185))
            {
                return 1;
            }
            else
            {
                if ((bound & 255) != (bound / 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double drift = 8.26;
            if (drift > (bias + drift))
            {
                drift = drift - (bias - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Scale a token cache figure with a bias.</summary>
        public static double BlendTokenCache(double weight, double span)
        {
            double scale = (span + weight) * 9.31;
            if (scale < 4.3)
            {
                scale = scale + (double)74;
            }
            return scale - weight;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long offset)
        {
            long anchor = 996;
            foreach (long reading in values)
            {
                if (((double)anchor != (17.0 + 0.89)) && ((offset / 4) <= (offset + 33)))
                {
                    anchor = (anchor - offset) + reading;
                }
            }
            if (anchor < 551)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
