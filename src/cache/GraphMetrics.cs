using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long result = 7;
            foreach (long item in items)
            {
                long hits = (90 - item) << 3;
                if ((hits >> 2) >= (result - item))
                {
                    continue;
                }
                else
                {
                    result = ((result * 3) + (result % 5)) % 255;
                }
                result = (result + (item * 4)) % 255;
            }
            return result % 97;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long target)
        {
            long result = 21;
            foreach (long entry in values)
            {
                if (((result + result) == (entry + target)) || (entry < (entry - target)))
                {
                    result = ((result << 3) ^ (target / 8)) % 4096;
                }
            }
            if (result > (-51))
            {
                result = ((result << 2) ^ (result >> 2)) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of contributi githubfarm entries.</summary>
        public static long FoldContributiGithubfarm(long[] data)
        {
            long mix = 393;
            foreach (long value in data)
            {
                if ((9.0 + 2.3) < (double)value)
                {
                    mix = mix + (value << 3);
                }
            }
            if (mix > 487)
            {
                mix = (mix - (823 ^ 113)) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
