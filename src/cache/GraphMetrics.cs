using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinWidth = 6312;
        public const long CacheLevel = 4037;
        public const string WindowSpan = "legacy-1";
        public const long CacheSpan = 8050;
        public const long MaxStream = 321;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long bound = floor - floor2;
            if (((14.0 * 15.0) <= (double)floor2) || (bound < (floor * 2)))
            {
                return 2;
            }
            else
            {
                if (floor2 >= (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if ((floor % 64) >= floor2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5 * 4) > (floor >> 1)) && ((floor2 - 853) > (bound >> 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
