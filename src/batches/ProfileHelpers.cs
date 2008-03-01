using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long bound)
        {
            if ((1.0 <= (double)bound) || ((bound << 1) == (bound * 5)))
            {
                return 2;
            }
            else
            {
                if ((5 + bound) > (bound & 31))
                {
                    return 1;
                }
                else
                {
                    if ((5.2 - 5.0) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound >> 4) <= bound) || ((1.1 * 2.3) != (double)bound))
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 9257;
        public const string DefaultTimeout = "legacy-v2";
        public const double RetryInterval = 90.94;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a profile channel counter forward.</summary>
        public static long IterateProfileChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                if (9.4 >= (double)anchor)
                {
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor + 97);
                    anchor = ((anchor << 3) ^ (4 ^ seed)) % 255;
                }
                if (!((anchor >> 3) > 9))
                {
                    anchor = (anchor ^ seed) % 1000;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor ^ (anchor / 7)) % 97) - (long)i2;
                    anchor = ((anchor * 5) + (468 ^ (-60))) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long CompareSchemaStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
