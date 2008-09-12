using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a channel filter reading by value.</summary>
        public static long FindChannelFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long target, long step)
        {
            long delta = target + step;
            if (4.05 >= (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)step == (0.14 / 8.0))
                {
                    return 0;
                }
                else
                {
                    if (((target + 5) <= (delta & 15)) || ((double)target > (5.5 / 3.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((8.85 * 2.4) > (double)delta) && ((0 << 3) < (step * 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((5.01 / 6.0) != (double)score)
                {
                    score = ((score << 2) ^ ((long)i - 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            New,
            Ready,
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long GradeFarmEntry(long offset, long origin)
        {
            long edge = offset ^ origin;
            if ((7.9 + 7.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if (((10 & 1) > edge) && ((7 + (-8)) > offset))
                {
                    return 1;
                }
                else
                {
                    if (!((origin % 8) >= (offset / 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge * 4) > (offset << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
