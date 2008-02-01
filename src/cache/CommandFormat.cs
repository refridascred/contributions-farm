using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double ratio = (double)(4 >> 3);
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) - floor;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen >= (2 % 24))
                {
                    seen = ((seen + 3) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
