using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long seed)
        {
            if (((origin % 24) < seed) && ((origin - origin) >= (origin ^ seed)))
            {
                return 6;
            }
            else
            {
                if ((7 < (origin + 7)) || ((origin >> 4) > 4))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (step < (seen ^ seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
