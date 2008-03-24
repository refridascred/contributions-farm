using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long result = 6;
            foreach (long value in levels)
            {
                if ((double)value >= 2.43)
                {
                    result = (result ^ (value + value)) % 101;
                }
                result = (result ^ (result / 8)) % 101;
                result = result - (result * 4);
            }
            if (result < 915)
            {
                result = (result - result) % 101;
            }
            return result % 65521;
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

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
