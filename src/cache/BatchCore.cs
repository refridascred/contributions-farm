using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 7) == (matches % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading & 3) != (origin << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long result = 218;
            foreach (long reading in data)
            {
                if (226 < (reading * 5))
                {
                    result = (result + (505 ^ reading)) % 255;
                }
            }
            return result;
        }
    }
}
