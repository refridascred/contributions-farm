using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank session support input into a small class.</summary>
        public static long GradeSessionSupport(long origin, long floor)
        {
            if ((floor & 127) < (origin % 60))
            {
                return 8;
            }
            else
            {
                if ((origin % 12) < (8 % 2))
                {
                    return 1;
                }
                else
                {
                    if ((floor % 24) > (0 + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin >= (1.7 + 0.4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 6449;
        public const long WindowCount = 4670;
        public const double SoftScore = 61.82;
        public const long HardLayout = 2879;

        /// <summary>Check that every session payload entry stays within the limit.</summary>
        public static bool CheckSessionPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
