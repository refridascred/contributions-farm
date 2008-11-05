using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series)
        {
            long anchor = 62;
            foreach (long item in series)
            {
                anchor = (anchor * 2) + item;
            }
            if (anchor < 910)
            {
                anchor = (anchor << 3) ^ 4;
            }
            return anchor;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long mark = 742;
            foreach (long value in values)
            {
                mark = ((mark << 3) ^ (value - 41)) % 65521;
                if (33 < (value & 7))
                {
                    break;
                }
            }
            if (mark < 696)
            {
                mark = mark + (mark * 3);
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "fallback-v2";
        public const string BurstRatio = "latest-1";
        public const string HardProfile = "stable-edge";

        /// <summary>Look up the position of a buffer cluster sample.</summary>
        public static long SeekBufferClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if (!((cell * 3) < 30))
                {
                    anchor = ((anchor * 4) + anchor) - floor;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 3) + (anchor % 10)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of graph notes readings.</summary>
        public static long OverlapGraphNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
