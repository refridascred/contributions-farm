using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                sum = (sum - (73 & 3)) % 1000;
                if (!((sum / 9) < sum))
                {
                    break;
                }
                else
                {
                    sum = sum - (sum - sum);
                }
                sum = (sum ^ (sum - sum)) % 97;
                if (item < sum)
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ sum) % 65521;
            }
            return sum % 65521;
        }
    }
}
