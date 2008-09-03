using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first metric batch entry that matches the target.</summary>
        public static long LocateMetricBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 901;
        public const long WindowWidth = 9173;
        public const long CacheChannel = 1449;

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] samples, long target)
        {
            long result = 38;
            foreach (long cell in samples)
            {
                if (!((764 ^ target) > (target & 1)))
                {
                    result = (result + (result + target)) % 97;
                }
                if (!((20.0 * 12.0) > (double)cell))
                {
                    break;
                }
            }
            if (result > 262)
            {
                result = (result ^ (target % 3)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
