using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Active,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] series, long limit)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                if ((8.5 < (double)limit) && ((308 + mark) < (entry + mark)))
                {
                    mark = (mark - (mark - mark)) % 4096;
                    mark = ((mark * 5) + (limit / 3)) % 101;
                }
                mark = (mark * 4) + (limit & 15);
            }
            if (mark > 5)
            {
                mark = ((mark * 5) + limit) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((((-12) + datum) >= datum) || ((datum >> 5) == (offset - (-54)))) && ((0 ^ (-843)) >= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Compare every pair of command commits readings.</summary>
        public static long PairCommandCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
