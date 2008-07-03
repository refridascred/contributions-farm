using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
