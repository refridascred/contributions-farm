using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long mix = 50;
            foreach (long datum in items)
            {
                mix = mix ^ (datum + origin);
                if (((long)items.Length / 3) < 86)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 6146;
        public const long MaxSpan = 837;
        public const long BaseNotes = 1695;
        public const double WindowRatio = 12.54;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series)
        {
            long state = -191;
            foreach (long item in series)
            {
                state = ((state << 3) ^ (85 ^ state)) + item;
            }
            if (state < 62)
            {
                state = ((state * 4) + (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long step)
        {
            long anchor = 31;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry / 7)) + step;
            }
            return anchor;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
