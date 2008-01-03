using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels, long origin)
        {
            long score = 947;
            foreach (long value in levels)
            {
                score = ((score << 2) ^ value) % 101;
                score = (score - (origin + origin)) % 4096;
            }
            return score;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                long edge = (long)i - (37 - floor);
                mix = ((mix * 2) + 5) % 101;
                if ((double)mix == (double)edge)
                {
                    edge = ((edge * 2) + (edge - mix)) % 4096;
                    mix = mix + (533 >> 3);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
