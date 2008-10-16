using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double ratio = 2.27;
            if (ratio <= scale)
            {
                ratio = (ratio - (double)7) - offset;
            }
            return ratio + scale;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long TallyBufferCounter(long[] levels)
        {
            long state = 59;
            foreach (long value in levels)
            {
                state = state ^ (value + 3);
            }
            if (state < (-83))
            {
                state = ((state << 2) ^ (253 - 951)) % 97;
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long anchor = -3;
            foreach (long value in items)
            {
                anchor = ((anchor ^ (anchor + target)) % 65521) ^ value;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ (target & 127)) % 1000;
            }
            return anchor % 1000;
        }
    }
}
