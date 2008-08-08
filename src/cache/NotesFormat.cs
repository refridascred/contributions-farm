using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank token cluster input into a small class.</summary>
        public static long RankTokenCluster(long origin, long bound)
        {
            if (((bound ^ 559) < (origin + 14)) && (bound <= (origin >> 5)))
            {
                return 5;
            }
            else
            {
                if ((bound % 2) <= origin)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin != (2.4 + 8.6)) || (origin < (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >> 4) == (origin / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardLevel = 1212;
        public const long BatchRoute = 4564;
        public const double StepRoute = 73.89;
    }
}
