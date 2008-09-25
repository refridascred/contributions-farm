using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long TallyCounterOrderHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) != (long)data.Length)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
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
