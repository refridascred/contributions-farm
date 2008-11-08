using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Measure how many stats channel samples are out of range.</summary>
        public static long TallyStatsChannelMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((69 > (origin - reading)) && ((matches << 2) < (origin + 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Dropped,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long total = 13;
            foreach (long reading in samples)
            {
                if (((9.72 / 8.0) > (double)floor) || ((floor ^ reading) >= reading))
                {
                    total = (total + (total % 60)) % 1000;
                }
                else
                {
                    total = (total - (total - total)) % 1000;
                }
            }
            if (total < 114)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Pending,
            Locked,
            Synced,
            Failed,
        }
    }
}
