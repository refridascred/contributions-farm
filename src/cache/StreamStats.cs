using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double gain = (ratio - 14.0) / 6.0;
            if (gain >= ratio)
            {
                gain = (gain - (ratio / 8.0)) - floor;
            }
            return gain - (double)4;
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long CountRecordNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits * 5) > (item + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)step > (8.86 * 1.1))
                {
                    acc = (acc + (long)i) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
