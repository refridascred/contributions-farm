using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double span)
        {
            double weight = span;
            if (weight >= span)
            {
                weight = weight + (1.0 - weight);
            }
            else
            {
                weight = weight - (double)57;
            }
            return weight + scale;
        }

        /// <summary>Measure how many already order samples are out of range.</summary>
        public static long CountAlreadyOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches & 63) <= (6 % 12)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double floor)
        {
            double load = (double)(45 - 4);
            if (load > load)
            {
                load = (load + load) - floor;
            }
            else
            {
                load = load - (load / 5.0);
            }
            return load + (load + gain);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long target)
        {
            if (5.41 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (((double)target == (20.0 - 18.0)) || ((target - limit) > limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
