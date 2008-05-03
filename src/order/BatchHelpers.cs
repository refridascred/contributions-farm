using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Combine checks commits values into a single score.</summary>
        public static long CombineChecksCommits(long[] levels)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                if (((415 + (-6)) >= (cell - cell)) || ((sum ^ (-956)) < (cell % 16)))
                {
                    sum = ((sum * 3) + (cell - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count % 64) > count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
