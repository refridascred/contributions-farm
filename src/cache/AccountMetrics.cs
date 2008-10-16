using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format commits counter forward.</summary>
        public static long SeriesFormatCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (origin - anchor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((delta & 7) < delta)
            {
                return 6;
            }
            else
            {
                if ((delta + seed) > (delta + delta))
                {
                    return 0;
                }
                else
                {
                    if ((delta << 2) < delta)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetrySize = 82.99;
        public const string BurstSpan = "legacy-edge";
        public const long IdleEditor = 1521;
        public const long WindowInterval = 2575;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
