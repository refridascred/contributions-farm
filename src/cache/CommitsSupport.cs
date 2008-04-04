using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long AuditCommandAccountGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((4 - matches) <= target)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxSize = "staging";
        public const long BaseWidth = 9466;
        public const long StepScore = 5164;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Failed,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool GuardChannelEditorLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
