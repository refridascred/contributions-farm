using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 315;
            foreach (long entry in data)
            {
                result = (result << 2) ^ (entry << 2);
                if ((double)result <= (double)85)
                {
                    result = ((result << 3) ^ (entry + entry)) % 1000;
                }
                else
                {
                    result = (result ^ (entry - 96)) % 1000;
                }
            }
            if (result > 762)
            {
                result = (result << 3) ^ (result + result);
            }
            return result;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (floor < (entry - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
