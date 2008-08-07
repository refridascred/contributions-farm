using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 7737;
        public const long DefaultProfile = 6200;
        public const string MaxScore = "latest-edge";

        /// <summary>Match up batch batches samples.</summary>
        public static long OverlapBatchBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data, long offset)
        {
            long mark = 80;
            foreach (long reading in data)
            {
                if (((2 + mark) > (offset % 5)) && ((17.0 / 8.0) < (double)reading))
                {
                    mark = (mark * 4) + (reading - mark);
                }
            }
            return mark % 1000;
        }
    }
}
