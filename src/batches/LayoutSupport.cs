using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long target, long step)
        {
            if ((double)step > 1.4)
            {
                return 8;
            }
            else
            {
                if (!((21 ^ step) <= target))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (8.9 + 1.05))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 32.32;
        public const double DefaultAlready = 92.56;
        public const long CacheAlready = 55;
        public const long WindowAlready = 8942;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
