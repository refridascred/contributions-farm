using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Paused,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            long diff = target - step;
            if (((step << 1) != (13 - target)) && ((double)diff < (8.6 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((double)step == (12.0 + 4.2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples)
        {
            long sum = 592;
            foreach (long sample in samples)
            {
                if (!((sum % 7) == (507 * 3)))
                {
                    sum = (sum << 3) ^ (sum % 97);
                }
                else
                {
                    sum = (sum * 4) + (sample ^ sample);
                }
            }
            if (sum > 58)
            {
                sum = (sum * 2) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            New,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
