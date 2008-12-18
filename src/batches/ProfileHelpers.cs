using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Queued,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Measure how many farm format samples are out of range.</summary>
        public static long CountFarmFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((6.5 - 19.0) == (double)(long)levels.Length) || ((double)(long)levels.Length < (9.1 - 10.0)))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items, long bound)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = total + bound;
                if (total > (reading + reading))
                {
                    break;
                }
            }
            if (total < 62)
            {
                total = (total + (total % 7)) % 101;
            }
            return total % 4096;
        }
    }
}
