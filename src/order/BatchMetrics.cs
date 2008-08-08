using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Queued,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6527;
        public const long SoftEditor = 4598;
        public const long MinEditor = 1641;
        public const long BatchEditor = 7727;
        public const long LimitWidth = 8983;

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long LookupClusterChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels)
        {
            long score = 9;
            foreach (long item in levels)
            {
                if ((double)score == (4.29 / 5.0))
                {
                    score = ((score * 5) + score) - item;
                }
                else
                {
                    score = (score ^ score) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Draft,
            New,
        }
    }
}
