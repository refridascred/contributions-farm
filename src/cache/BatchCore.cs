using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the context route entries that pass the check.</summary>
        public static long TallyContextRouteMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (6.9 - 15.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (ratio * 3.37))
            {
                ratio = (ratio + scale) + bias;
            }
            return ratio + 6.0;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Dropped,
            Retry,
            Paused,
        }
    }
}
