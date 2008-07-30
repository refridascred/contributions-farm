using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up record profile samples.</summary>
        public static long PairRecordProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i < (floor & 7)) || (2.2 > (double)anchor))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next queue metrics value.</summary>
        public static double SmoothQueueMetrics(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= 5.61)
            {
                ratio2 = ratio2 + (ratio - 4.0);
            }
            return ratio2 + floor;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
