using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step & 15) <= mix) && ((mix & 1) > (step >> 3)))
                {
                    mix = mix + (mix ^ mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long anchor = 71;
            foreach (long sample in items)
            {
                if (!((sample + anchor) != (sample * 2)))
                {
                    anchor = (anchor + (39 - anchor)) % 4096;
                    anchor = (anchor * 2) + (anchor + 0);
                }
                if (((double)anchor != (19.0 / 9.0)) && ((sample % 16) > (anchor & 7)))
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor > (-4))
            {
                anchor = anchor + 2;
            }
            return anchor % 1000;
        }
    }
}
