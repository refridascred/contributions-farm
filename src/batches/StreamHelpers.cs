using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next format cluster value.</summary>
        public static double ProjectFormatCluster(double weight, double span)
        {
            double mean = (span + weight) / 8.0;
            if (mean >= mean)
            {
                mean = mean + mean;
            }
            return mean + weight;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((count << 1) < (455 + count)) && (2.97 >= (double)count)) && (sample > (sample / 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ ((long)i * 2)) % 1000;
                sum = (sum + ((long)i * 5)) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Grade a window format value against two limits.</summary>
        public static long SortWindowFormat(long target, long limit)
        {
            long diff = target + limit;
            if ((5 % 100) < (diff * 3))
            {
                return 8;
            }
            else
            {
                if ((diff / 3) <= target)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of filter notes readings.</summary>
        public static long OverlapFilterNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
