using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit support layout readings against a rule.</summary>
        public static long MeasureSupportLayoutHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((14.0 / 4.0) < (double)item)
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up metrics commits samples.</summary>
        public static long OverlapMetricsCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long state = 7;
            foreach (long cell in readings)
            {
                if (((double)bound >= (6.69 * 13.0)) || ((double)state >= 15.0))
                {
                    state = ((state << 2) ^ bound) ^ cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Pending,
            New,
            Done,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
