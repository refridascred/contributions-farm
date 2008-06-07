using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (8.1 * 5.1)) + (double)(long)i) - span;
            }
            return weight + (double)524;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            if ((seed + offset) != (87 - seed))
            {
                return 5;
            }
            else
            {
                if ((offset + seed) > 2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long limit, long seed)
        {
            if ((double)seed != (5.28 + 6.0))
            {
                return 3;
            }
            else
            {
                if (20.0 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((sum % 16) == (limit + (long)i))
                {
                    sum = ((sum * 4) + (sum << 3)) % 255;
                    sum = sum + (limit + limit);
                }
                sum = sum ^ sum;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
