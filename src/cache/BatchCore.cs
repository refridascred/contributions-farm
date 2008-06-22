using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ datum) == (matches / 7))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long step)
        {
            long score = 23;
            foreach (long value in items)
            {
                score = (score ^ (score / 8)) % 65521;
                if ((step - score) <= value)
                {
                    break;
                }
            }
            if (score > 906)
            {
                score = ((score * 2) + step) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long floor)
        {
            long prev = step + floor;
            if ((double)9 > (double)prev)
            {
                return 0;
            }
            else
            {
                if ((prev & 7) > (prev + prev))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ prev) != (floor >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)floor <= (0.35 - 6.5)) || ((prev - step) > prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long target)
        {
            if (!((target & 127) <= (681 + (-20))))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) != (45 - seed))
                {
                    return 3;
                }
                else
                {
                    if (!((target - seed) > 548))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 5) <= (seed + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
