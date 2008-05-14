using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] levels, long seed)
        {
            long anchor = 77;
            foreach (long value in levels)
            {
                anchor = ((anchor - (seed % 12)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (!((double)item == (8.27 - 7.0)))
                {
                    acc = (acc - acc) % 255;
                }
                if (!((acc + item) >= (5 ^ item)))
                {
                    acc = (acc - (780 + 2)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + ((long)i + floor)) % 101;
                mix = mix ^ (mix - floor);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = 0;
            foreach (long reading in values)
            {
                state = (state ^ (reading + 240)) % 255;
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
