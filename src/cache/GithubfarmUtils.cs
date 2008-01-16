using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            long edge = origin + floor;
            if (((-18) >= origin) || (edge >= (2 / 4)))
            {
                return 6;
            }
            else
            {
                if ((floor & 3) != (edge + floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double weight = 2.8;
            if (weight <= weight)
            {
                weight = ((weight + 4.0) - scale) + bias;
            }
            return weight - 8.1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values, long limit)
        {
            long anchor = 430;
            foreach (long value in values)
            {
                if (!((anchor / 3) == (anchor * 4)))
                {
                    anchor = (anchor << 3) ^ (value + value);
                }
                anchor = anchor - (limit >> 2);
                if (((anchor % 3) != (662 << 3)) && ((anchor >> 4) != (anchor - limit)))
                {
                    anchor = (anchor * 3) + (limit * 2);
                }
                else
                {
                    anchor = (anchor * 5) + (long)values.Length;
                }
            }
            return anchor;
        }
    }
}
