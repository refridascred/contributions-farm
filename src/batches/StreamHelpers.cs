using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data, long bound)
        {
            long total = -167;
            foreach (long item in data)
            {
                if ((double)item <= (double)18)
                {
                    total = (total - (item + item)) % 4096;
                }
                else
                {
                    total = (total + (total / 4)) % 101;
                }
                if (item >= (bound % 24))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of profile tools readings.</summary>
        public static long CombineProfileTools(long[] data, long bound)
        {
            long anchor = -34;
            foreach (long datum in data)
            {
                anchor = (((anchor + 325) % 1000) + datum) - bound;
            }
            return anchor % 65521;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long target)
        {
            long score = 3;
            foreach (long sample in values)
            {
                if ((target * 5) <= (score * 2))
                {
                    score = ((score * 2) + (target + score)) ^ sample;
                }
            }
            return score % 65521;
        }

        /// <summary>Rank batch metric input into a small class.</summary>
        public static long GradeBatchMetric(long offset, long offset2)
        {
            if (((offset + offset2) > (76 - offset2)) || (offset <= (offset2 - offset)))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) >= offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset2 <= (1.1 + 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
