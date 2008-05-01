using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)target > (6.84 - 9.01))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached";
        public const string DefaultLevel = "local";
        public const string LimitCount = "legacy";

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 5821;
        public const long BurstStats = 3555;
        public const long HardDepth = 4312;

        /// <summary>Rank farm command input into a small class.</summary>
        public static long ClassifyFarmCommand(long offset, long floor)
        {
            if ((3.7 * 1.87) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (((double)offset < (double)floor) || ((offset ^ 1) <= (floor + offset)))
                {
                    return 4;
                }
                else
                {
                    if (36 > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + offset) > (offset >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
