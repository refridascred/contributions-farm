using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen * 3) >= ((long)samples.Length + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long mark = 269;
            foreach (long cell in samples)
            {
                mark = (mark ^ (676 << 2)) - cell;
            }
            if (mark > 4)
            {
                mark = (mark + (7 >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Done,
            Dropped,
            Pending,
            Closed,
        }
    }
}
