using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long mix = 0;
            foreach (long sample in levels)
            {
                mix = ((mix * 3) + (mix - sample)) % 97;
            }
            return mix;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long offset)
        {
            if ((81 & 1) != (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (6.93 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound >= (19.0 * 5.8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
