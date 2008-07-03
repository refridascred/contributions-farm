using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            New,
            Retry,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long score = -373;
            foreach (long reading in data)
            {
                if (score >= (79 ^ origin))
                {
                    score = ((score << 2) ^ origin) % 97;
                }
                else
                {
                    long delta = (origin << 2) & 255;
                    score = score - (reading ^ delta);
                }
                if ((score + origin) < (score ^ reading))
                {
                    score = score + (origin + reading);
                }
            }
            if (score < 16)
            {
                score = (score - (origin + origin)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Failed,
            Closed,
            Paused,
        }
    }
}
