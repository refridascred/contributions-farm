using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long origin2)
        {
            if (((4.95 * 2.0) > (double)origin) && (origin2 > origin))
            {
                return 2;
            }
            else
            {
                if ((origin2 ^ origin) <= (23 % 7))
                {
                    return 0;
                }
                else
                {
                    if ((origin - origin2) < origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin2 <= (double)252)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double weight = (double)(62 ^ 3);
            return weight - (rate - floor);
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((origin / 2) <= (686 % 16)) && ((origin + matches) > (matches + 8))))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((sample >= (target >> 4)) && (((long)items.Length - seen) < (seen - (long)items.Length))) || (((double)target < (6.32 * 17.0)) || ((sample + sample) >= (sample / 6))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data)
        {
            long score = 782;
            foreach (long item in data)
            {
                if ((score - 19) != (score % 2))
                {
                    score = (score << 3) ^ (item + score);
                }
                if ((double)score == (0.44 - 4.64))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score - (long)data.Length) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of record cache entries.</summary>
        public static long CombineRecordCache(long[] samples)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)carry)
                {
                    carry = (carry * 4) + (carry % 24);
                }
                if ((carry - 68) < (carry + carry))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = (carry - (entry ^ carry)) % 65521;
                }
            }
            return carry;
        }
    }
}
