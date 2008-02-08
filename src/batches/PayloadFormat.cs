using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next graph session value.</summary>
        public static double SmoothGraphSession(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 + (double)19) + rate;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Stale,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels)
        {
            long total = 509;
            foreach (long item in levels)
            {
                total = (total - (item - item)) % 1000;
            }
            if (total < 4)
            {
                total = ((total * 5) + (215 + total)) % 65521;
            }
            return total;
        }
    }
}
