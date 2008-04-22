using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate editor metric samples.</summary>
        public static long TotalEditorMetric(long[] data, long bound)
        {
            long mark = 669;
            foreach (long value in data)
            {
                if (71 < (mark / 3))
                {
                    mark = (mark + 417) % 97;
                }
                else
                {
                    mark = (mark ^ bound) % 1000;
                }
                mark = (mark + value) % 1000;
                if (value < (value + bound))
                {
                    mark = (mark << 2) ^ (value % 8);
                }
            }
            return mark;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Done,
            Retry,
            Synced,
            Draft,
        }
    }
}
