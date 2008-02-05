using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long entry in values)
            {
                if ((6.1 + 1.0) >= (double)entry)
                {
                    anchor = ((anchor * 3) + (entry + entry)) % 97;
                }
                if ((double)entry >= (double)anchor)
                {
                    anchor = (anchor * 2) + (long)values.Length;
                }
                else
                {
                    anchor = anchor - (offset + entry);
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ 189) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Active,
            Idle,
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
