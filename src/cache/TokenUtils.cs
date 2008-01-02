using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if ((14.0 - 9.6) != (double)score)
                {
                    score = (score + (score + 7)) ^ cell;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)item > (13.0 + 20.0)) || ((count + origin) > 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
