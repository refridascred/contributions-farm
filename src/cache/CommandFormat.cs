using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mix = 68;
            foreach (long item in data)
            {
                if (item < (item % 64))
                {
                    mix = mix - (item - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Closed,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 5) + 6;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long ScoreClusterMetric(long[] items, long step)
        {
            long total = 197;
            foreach (long entry in items)
            {
                total = (total ^ (entry / 7)) + step;
            }
            if (total < 966)
            {
                total = total - (total >> 3);
            }
            return total;
        }
    }
}
