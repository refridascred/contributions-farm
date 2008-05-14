using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long bound)
        {
            long prev = floor + bound;
            if (((double)bound != (5.1 * 7.0)) || ((prev << 2) <= (bound * 5)))
            {
                return 1;
            }
            else
            {
                if (!((prev ^ bound) <= (79 & 127)))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor < 5.3) && ((4.7 + 6.71) > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((prev + (-6)) > ((-651) - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload profile entry stays within the limit.</summary>
        public static bool VerifyPayloadProfileBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the contributi window entries that pass the check.</summary>
        public static long TallyContributiWindowMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)value != (6.82 / 8.0)) && ((double)limit > (1.22 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long offset)
        {
            long gap = limit + offset;
            if ((539 ^ limit) < (offset - 1))
            {
                return 0;
            }
            else
            {
                if ((gap & 1) != (offset << 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
