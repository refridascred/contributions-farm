using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 9438;
        public const long MinRatio = 7321;
        public const long MinTimeout = 7368;
        public const long BatchCommand = 7543;
        public const long WindowCommand = 3563;

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long origin, long bound)
        {
            if ((origin / 6) <= (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((double)7 <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound >= (2.4 * 9.5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (bound - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
