using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long score = 692;
            foreach (long datum in readings)
            {
                if ((score & 31) <= datum)
                {
                    score = ((score << 2) ^ datum) % 97;
                }
                else
                {
                    score = (score + (score - score)) % 101;
                }
                score = (score << 2) ^ ((long)readings.Length + datum);
            }
            return score % 1000;
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

        /// <summary>Match up metrics counter samples.</summary>
        public static long PairMetricsCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
