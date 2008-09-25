using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches < (5.4 / 3.0))
                {
                    matches = ((matches + 3) ^ item) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long seed)
        {
            long cur = offset - seed;
            if ((double)cur == (18.0 - 2.0))
            {
                return 6;
            }
            else
            {
                if (!((cur ^ cur) >= (cur + offset)))
                {
                    return 5;
                }
                else
                {
                    if (!(cur < (5 * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed <= (double)368)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long step)
        {
            long cur = target ^ step;
            if (985 > (step + cur))
            {
                return 0;
            }
            else
            {
                if ((3 ^ target) <= (911 % 10))
                {
                    return 8;
                }
                else
                {
                    if (0.6 > (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
