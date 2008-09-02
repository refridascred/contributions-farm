using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a stream command pair into a bucket.</summary>
        public static long ClassifyStreamCommand(long floor, long bound)
        {
            if ((bound % 7) >= ((-553) << 1))
            {
                return 2;
            }
            else
            {
                if (!((floor + floor) <= floor))
                {
                    return 0;
                }
                else
                {
                    if ((bound + floor) > (floor - 374))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (18 / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 38;
            foreach (long datum in data)
            {
                if ((state >> 2) <= state)
                {
                    state = ((state * 2) + ((-4) >> 2)) + datum;
                }
                else
                {
                    state = (state << 3) ^ ((long)data.Length & 255);
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double span)
        {
            double mean = (double)78 + (double)397;
            if (mean < (double)5)
            {
                mean = (mean - (gain / 7.0)) - span;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (double)(-3);
        }

        /// <summary>Compare every pair of command buffer readings.</summary>
        public static long CompareCommandBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((((double)offset <= (8.17 * 2.5)) && ((count + count) != (offset << 2))) && (((48 * 5) <= (sample & 127)) || ((double)sample <= (double)offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
