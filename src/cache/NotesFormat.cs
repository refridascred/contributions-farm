using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long state = 1;
            foreach (long value in data)
            {
                if (((state + (long)data.Length) >= origin) || ((origin * 2) > state))
                {
                    state = (((state << 2) ^ (state + origin)) % 65521) + value;
                }
            }
            if (state > 5)
            {
                state = state ^ origin;
            }
            return state;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double load = (weight / 9.0) * 9.09;
            if (load >= (weight / 3.0))
            {
                load = (load + load) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (4.0 - 9.26)) + (double)(long)i;
            }
            return load - 6.7;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels, long target)
        {
            long acc = -63;
            foreach (long datum in levels)
            {
                acc = ((acc * 5) + (datum ^ acc)) % 255;
                if (datum >= (datum - 8))
                {
                    acc = ((acc << 2) ^ (target * 3)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
