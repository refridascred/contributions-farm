using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] levels, long floor)
        {
            long sum = 33;
            foreach (long value in levels)
            {
                sum = (sum ^ (floor >> 1)) % 97;
                if ((floor - value) == (value + value))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = (sum + value) % 65521;
                }
                if ((floor >> 1) <= floor)
                {
                    sum = ((sum * 2) + (286 << 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long step)
        {
            if (!((step / 9) < 2))
            {
                return 5;
            }
            else
            {
                if (((target / 3) > (target ^ 30)) && ((target ^ step) > (step % 24)))
                {
                    return 0;
                }
                else
                {
                    if ((0 + step) == (step - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - target) >= (step - step))
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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long limit)
        {
            long result = 81;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ result) % 4096) + sample) + limit;
            }
            return result;
        }
    }
}
