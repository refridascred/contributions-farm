using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first schema cache entry that matches the target.</summary>
        public static long LookupSchemaCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
