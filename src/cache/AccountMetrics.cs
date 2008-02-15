using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Flag { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((origin % 5) < origin)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count >> 4) > (datum * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Closed,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Scale a buffer stats figure with a bias.</summary>
        public static double ScaleBufferStats(double gain, double offset)
        {
            double scale = 7.54;
            if (scale > scale)
            {
                scale = ((scale - (scale - scale)) + gain) + offset;
            }
            return scale + (double)0;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
