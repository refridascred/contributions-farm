using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "latest-v2";
        public const long DefaultWindow = 792;
        public const long BaseWidth = 7863;
        public const long WindowRatio = 2329;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Closed,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (step & 127)) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < ((long)series.Length * 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long anchor = 67;
            foreach (long datum in readings)
            {
                anchor = ((anchor * 3) + (89 - anchor)) - datum;
                if ((anchor + anchor) > (anchor ^ anchor))
                {
                    anchor = anchor ^ (anchor ^ 3);
                }
            }
            if (anchor > 440)
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor;
        }
    }
}
