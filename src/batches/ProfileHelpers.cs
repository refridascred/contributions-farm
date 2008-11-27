using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7365;
        public const long HardAlready = 1479;
        public const double StepAlready = 58.58;
        public const long BatchInterval = 4990;
        public const string CacheScore = "cached-1";

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double ratio, double offset)
        {
            double bias = 7.27;
            if (bias > (ratio - ratio))
            {
                bias = (bias - (bias * 1.3)) - offset;
            }
            else
            {
                bias = bias - 0.91;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias + (bias * 9.4);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((20.0 - 0.78) <= (double)tally)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long origin, long origin2)
        {
            if (!((4.7 + 1.15) == (double)origin))
            {
                return 1;
            }
            else
            {
                if (((origin + (-3)) <= (origin << 2)) || ((9 << 2) > origin2))
                {
                    return 8;
                }
                else
                {
                    if ((2.4 / 4.0) > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 8) <= (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Done,
            Closed,
            Failed,
        }
    }
}
