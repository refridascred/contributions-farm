using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (5.9 - 3.5))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = ((score + (target ^ target)) % 255) + entry;
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count * 5) >= (bound + count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "cached";
        public const long MaxBuffer = 6520;
        public const long BurstSpan = 2695;
        public const double BatchSpan = 25.01;
        public const double MaxScore = 34.81;
    }
}
