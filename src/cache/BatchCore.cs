using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((((long)series.Length + seen) >= (5 & 1)) && ((datum / 9) == ((-1) - step))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine context stream values into a single score.</summary>
        public static long TotalContextStream(long[] items, long offset)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                mix = (((mix - (mix >> 4)) % 255) + entry) + offset;
                mix = (mix ^ 75) % 4096;
            }
            if (mix < 8)
            {
                mix = ((mix << 3) ^ (87 / 9)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Idle,
            Synced,
            New,
            Queued,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels)
        {
            long anchor = 990;
            foreach (long sample in levels)
            {
                anchor = (anchor - (sample + sample)) % 4096;
                anchor = (anchor << 2) ^ (306 & 255);
                if (((double)anchor <= (double)471) && ((double)sample < (8.0 + 9.0)))
                {
                    anchor = (anchor + (anchor & 63)) % 101;
                }
            }
            return anchor % 1000;
        }
    }
}
