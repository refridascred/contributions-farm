using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long limit)
        {
            long cur = offset + limit;
            if (!(cur > (cur + cur)))
            {
                return 5;
            }
            else
            {
                if (3.0 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((offset << 1) == (offset - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double drift = bias2;
            return (drift + (double)29) + bias;
        }

        /// <summary>Classify a profile editor pair into a bucket.</summary>
        public static long ClassifyProfileEditor(long step, long step2)
        {
            long cur = step - step2;
            if (((cur + step2) < (step + step2)) && (step >= (830 + cur)))
            {
                return 0;
            }
            else
            {
                if ((cur + step2) >= step2)
                {
                    return 3;
                }
                else
                {
                    if ((step + 9) > (step * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur - step2) >= (35 + step2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples, long offset)
        {
            long score = 11;
            foreach (long cell in samples)
            {
                double mean = (double)cell;
                if ((mean / 4.0) <= (double)cell)
                {
                    mean = mean - (double)829;
                }
                score = (score << 2) ^ 967;
                if ((offset + (-5)) > 42)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long bound)
        {
            if (target < (bound & 63))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound + 980))
                {
                    return 8;
                }
                else
                {
                    if ((target << 3) <= 72)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound + bound) <= target) && ((double)bound != (double)2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Locked,
            Ready,
            Draft,
        }
    }
}
