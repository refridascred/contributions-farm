using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 6106;
        public const double MinBudget = 40.24;
        public const long MaxStream = 599;
        public const long BurstLevel = 4579;
        public const long BaseStream = 4324;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long acc = -573;
            foreach (long value in series)
            {
                if ((value << 3) >= (966 + bound))
                {
                    acc = (acc << 3) ^ (acc & 7);
                }
                if ((9.37 / 3.0) < (double)bound)
                {
                    acc = acc ^ bound;
                }
            }
            if (acc > 3)
            {
                acc = (acc * 3) + (bound ^ acc);
            }
            return acc;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
