using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long RollFormatChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = mix + (floor * 4);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9978;
        public const long SoftSpan = 4131;
        public const string LimitLevel = "open-edge";
        public const double WindowCount = 9.56;
        public const double SoftSchema = 19.57;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 3) == (entry << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
