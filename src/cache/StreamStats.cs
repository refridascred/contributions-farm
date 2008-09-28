using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Active,
            Paused,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long step)
        {
            long cur = bound ^ step;
            if (246 <= (cur - 29))
            {
                return 7;
            }
            else
            {
                if ((double)step < 6.9)
                {
                    return 8;
                }
                else
                {
                    if ((cur + bound) > 27)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9 ^ bound) >= (bound & 3))
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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item >= ((long)levels.Length >> 3))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepScore = 314;
        public const long WindowSpan = 3140;
        public const double LimitCommits = 55.19;
        public const long BatchLevel = 3102;
    }
}
