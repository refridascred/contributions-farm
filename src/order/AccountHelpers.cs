using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metrics format readings.</summary>
        public static long TotalMetricsFormat(long[] values, long bound)
        {
            long anchor = 61;
            foreach (long cell in values)
            {
                if ((bound + anchor) == (anchor + anchor))
                {
                    anchor = (anchor * 2) + (anchor * 4);
                    anchor = (anchor ^ cell) % 97;
                }
                else
                {
                    anchor = (anchor ^ (737 + 9)) % 255;
                }
                if ((anchor / 7) == (407 % 5))
                {
                    anchor = anchor ^ (bound + bound);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Pending,
            New,
            Stale,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long offset)
        {
            long mix = 82;
            foreach (long reading in values)
            {
                if (offset < (reading / 3))
                {
                    mix = mix + (mix * 3);
                }
                else
                {
                    mix = mix - (offset / 6);
                }
            }
            if (mix > 48)
            {
                mix = (mix - (offset + offset)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
