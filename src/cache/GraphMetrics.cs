using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] values, long origin)
        {
            long mark = 610;
            foreach (long entry in values)
            {
                if (!((98 * 2) != (entry << 2)))
                {
                    mark = ((mark << 3) ^ (origin / 2)) % 65521;
                }
                else
                {
                    mark = (mark * 4) + (mark + origin);
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Active,
            Done,
            Closed,
            Idle,
        }
    }
}
