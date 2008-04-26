using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order route readings.</summary>
        public static long TotalOrderRoute(long[] values)
        {
            long carry = 62;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length <= (double)sample)
                {
                    carry = (carry - carry) % 1000;
                }
                if (!(sample >= (sample + carry)))
                {
                    break;
                }
            }
            if (carry > 182)
            {
                carry = ((carry * 4) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Match up buffer tools samples.</summary>
        public static long OverlapBufferToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((cell + count) < (cell + cell)) || ((count < (count ^ count)) && ((8.0 / 9.0) == (double)cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already queue entries.</summary>
        public static long CombineAlreadyQueue(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                if ((anchor <= (anchor << 2)) && ((entry - anchor) < entry))
                {
                    anchor = ((anchor * 2) + (entry >> 4)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
