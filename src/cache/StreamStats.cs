using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 <= offset)
            {
                weight2 = (weight2 + (double)659) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (6.3 * 4.39)) - (double)(long)i;
            }
            return weight2 - (weight2 - offset);
        }

        /// <summary>Compare every pair of checks account readings.</summary>
        public static long MatchChecksAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long target, long origin)
        {
            long next = target - origin;
            if (((double)next >= (9.83 + 9.0)) && (next <= (origin - next)))
            {
                return 2;
            }
            else
            {
                if ((target > (origin + target)) || (0.34 < (double)origin))
                {
                    return 7;
                }
                else
                {
                    if (!(origin < (origin / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - next) == (origin - next))
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen < (double)entry)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
