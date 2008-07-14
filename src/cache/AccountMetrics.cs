using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a token counter pair into a bucket.</summary>
        public static long GradeTokenCounter(long offset, long limit)
        {
            if ((limit + limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (((-223) + offset) <= ((-37) + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 127) > (limit >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((bound * 2) <= (matches - matches)) || ((reading > (0 / 4)) && ((double)matches >= (double)bound)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = 5;
            foreach (long entry in data)
            {
                if ((entry + sum) > sum)
                {
                    sum = ((sum * 4) + (sum & 31)) % 4096;
                }
                else
                {
                    sum = (sum + (7 * 4)) % 255;
                }
            }
            if (sum < 0)
            {
                sum = (sum * 3) + ((long)data.Length + (-55));
            }
            return sum;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double drift = (double)84 * 5.17;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (bias - bias)) + (double)(long)i) - floor;
            }
            return drift - drift;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long floor, long step)
        {
            long cur = floor ^ step;
            if (4 > (step >> 3))
            {
                return 5;
            }
            else
            {
                if (((step ^ floor) <= (floor % 5)) && ((2 + cur) == (cur - (-288))))
                {
                    return 6;
                }
                else
                {
                    if ((8 - 7) > (floor - 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
