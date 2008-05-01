using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many graph metric samples are out of range.</summary>
        public static long MeasureGraphMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) == (entry * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Pending,
            New,
            Done,
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit + result) > (result * 5))
                {
                    continue;
                }
                if (!((limit >> 2) == (limit & 63)))
                {
                    result = result + (limit & 31);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Queued,
            Paused,
        }
    }
}
