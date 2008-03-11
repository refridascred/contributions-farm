using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a window route pair into a bucket.</summary>
        public static long ClassifyWindowRoute(long target, long origin)
        {
            if (origin <= 9)
            {
                return 3;
            }
            else
            {
                if (((origin + origin) <= (target % 16)) || ((double)origin != (13.0 - 6.76)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
