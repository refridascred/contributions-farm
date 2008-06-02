using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up graph batch samples.</summary>
        public static long PairGraphBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstInterval = 4685;
        public const long BaseCount = 5101;
        public const long DefaultBudget = 9294;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long anchor = 317;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin % 3)) % 255) + sample;
            }
            return anchor;
        }
    }
}
