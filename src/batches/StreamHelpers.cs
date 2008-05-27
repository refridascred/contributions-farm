using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long score = 37;
            foreach (long reading in readings)
            {
                score = ((score << 3) ^ (score & 127)) % 4096;
                if (((reading - score) < (28 >> 3)) && ((18.0 + 3.74) <= (double)reading))
                {
                    score = (score << 3) ^ (score + reading);
                }
            }
            return score;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long bound2)
        {
            if ((bound + bound2) >= (0 * 3))
            {
                return 0;
            }
            else
            {
                if (7.0 >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (bound >= (bound << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate entry counter readings against a bound.</summary>
        public static bool CheckEntryCounterLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long target)
        {
            long delta = seed + target;
            if (!(seed > (target / 6)))
            {
                return 6;
            }
            else
            {
                if ((4.86 / 5.0) > (double)delta)
                {
                    return 0;
                }
                else
                {
                    if (5.63 < (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta / 9) >= (delta + 59))
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
