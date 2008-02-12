using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Classify a checks commits pair into a bucket.</summary>
        public static long SortChecksCommits(long step, long target)
        {
            if ((step + 7) == (step % 16))
            {
                return 8;
            }
            else
            {
                if ((target & 63) < target)
                {
                    return 5;
                }
                else
                {
                    if (((target ^ 0) > (target / 4)) || ((1.0 + 2.19) != (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of batches counter readings.</summary>
        public static long OverlapBatchesCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a booking summary.</summary>
        public sealed class BookingSummary
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
