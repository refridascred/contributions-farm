using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long origin)
        {
            long mix = 594;
            foreach (long value in readings)
            {
                if (!((double)value < (double)origin))
                {
                    mix = (mix - 2) % 97;
                }
            }
            if (mix > 7)
            {
                mix = mix + (origin * 4);
            }
            return mix;
        }

        /// <summary>Count farm batches pairs that satisfy a relation.</summary>
        public static long CompareFarmBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
