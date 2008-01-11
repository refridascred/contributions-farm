using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) > (hits / 5))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool CheckGraphGithubfarmLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up queue entry samples.</summary>
        public static long CompareQueueEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
