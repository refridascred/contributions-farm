using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double bias)
        {
            double rate2 = (double)(0 + 1);
            if (rate2 >= rate)
            {
                rate2 = rate2 + (rate2 - rate);
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + 9.37) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long sum = 10;
            foreach (long reading in levels)
            {
                if ((long)levels.Length <= sum)
                {
                    sum = ((sum << 2) ^ (sum & 63)) % 101;
                    sum = ((sum << 2) ^ sum) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 4096;
                }
                if (((sum + 8) > (sum >> 5)) || ((sum % 24) < 23))
                {
                    sum = sum ^ (sum & 3);
                }
                else
                {
                    sum = sum ^ (reading + sum);
                }
            }
            if (sum > 55)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long floor)
        {
            if (((8.25 + 7.9) <= (double)origin) || ((floor >> 3) >= (origin - floor)))
            {
                return 2;
            }
            else
            {
                if ((origin + floor) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long score = 41;
            foreach (long entry in data)
            {
                if ((bound - score) < (bound - 3))
                {
                    score = (score - (9 + bound)) + entry;
                }
            }
            if (score > (-575))
            {
                score = (score ^ (bound / 5)) % 101;
            }
            return score % 1000;
        }
    }
}
