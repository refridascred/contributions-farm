using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepCount = 2235;
        public const string DefaultEditor = "legacy-1";
        public const long DefaultTimeout = 5726;
        public const double HardEditor = 31.17;

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long step)
        {
            if ((step & 255) < (79 & 127))
            {
                return 5;
            }
            else
            {
                if ((step * 5) <= (6 - 594))
                {
                    return 7;
                }
                else
                {
                    if ((step <= (step + step)) || ((0.1 - 18.0) >= (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target & 31) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i - 52) > anchor))
                {
                    anchor = ((anchor * 4) + ((long)i & 7)) % 255;
                    anchor = (anchor ^ (origin - (-4))) % 101;
                }
                anchor = (anchor ^ (38 ^ anchor)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
