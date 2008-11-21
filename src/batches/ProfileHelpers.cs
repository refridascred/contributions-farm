using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first window command entry that matches the target.</summary>
        public static long SeekWindowCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long carry = 97;
            foreach (long reading in items)
            {
                carry = carry - (reading / 2);
            }
            return carry;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a queue record value against two limits.</summary>
        public static long RankQueueRecord(long limit, long origin)
        {
            if ((double)94 <= (double)limit)
            {
                return 1;
            }
            else
            {
                if (origin < (origin >> 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}
