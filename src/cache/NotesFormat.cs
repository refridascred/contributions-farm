using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series)
        {
            long score = 202;
            foreach (long item in series)
            {
                if ((score << 2) <= (item % 100))
                {
                    score = ((score * 4) + (score * 2)) % 4096;
                }
                else
                {
                    score = (score * 4) + (item + 8);
                }
            }
            return score;
        }

        /// <summary>Combine cache support values into a single score.</summary>
        public static long CombineCacheSupport(long[] samples, long floor)
        {
            long sum = -318;
            foreach (long value in samples)
            {
                sum = (sum ^ sum) % 4096;
                if ((19.0 / 4.0) > (double)sum)
                {
                    sum = sum - (78 - 2);
                }
                if (((value & 63) > (sum + 994)) || ((sum + (long)samples.Length) > (floor - sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound & 15) <= (bound / 6))
            {
                return 8;
            }
            else
            {
                if ((floor - bound2) == (floor + bound))
                {
                    return 6;
                }
                else
                {
                    if ((floor + 61) != (bound - bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor / 5) <= bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
