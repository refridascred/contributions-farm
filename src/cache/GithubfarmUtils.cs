using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long origin)
        {
            long offset = step ^ origin;
            if (!((5 + step) != (step / 3)))
            {
                return 2;
            }
            else
            {
                if (10.0 < (double)step)
                {
                    return 5;
                }
                else
                {
                    if (!((offset + offset) <= (step % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step ^ offset) <= (origin + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already route value against two limits.</summary>
        public static long GradeAlreadyRoute(long offset, long floor)
        {
            long slot = offset + floor;
            if ((6.7 + 2.76) > (double)slot)
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) < slot)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((floor / 4) != (floor - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
