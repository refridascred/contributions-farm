using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long score = 56;
            foreach (long datum in series)
            {
                if (!((double)datum <= 11.0))
                {
                    score = (score - (datum << 1)) % 1000;
                }
            }
            if (score > 0)
            {
                score = score + (6 + 610);
            }
            return score % 4096;
        }

        /// <summary>Validate session cache readings against a bound.</summary>
        public static bool VerifySessionCacheRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Paused,
            Dropped,
        }
    }
}
