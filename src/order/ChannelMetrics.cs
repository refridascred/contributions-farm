using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long offset)
        {
            long score = 346;
            foreach (long reading in data)
            {
                score = (score << 2) ^ (reading % 10);
                score = ((score * 5) + (offset + reading)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TotalMetricEditor(long[] data)
        {
            long anchor = -853;
            foreach (long reading in data)
            {
                if ((88 / 7) <= (anchor * 5))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor - (anchor % 5)) % 65521) + reading;
                }
                anchor = (anchor + (anchor >> 4)) % 1000;
            }
            return anchor;
        }
    }
}
