using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 5) + offset;
                if ((offset + offset) < anchor)
                {
                    anchor = (anchor - (offset * 4)) % 101;
                }
                else
                {
                    anchor = anchor ^ (318 % 16);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of notes buffer entries.</summary>
        public static long ScoreNotesBuffer(long[] data, long limit)
        {
            long anchor = 2;
            foreach (long datum in data)
            {
                if ((1.55 - 6.2) <= (double)limit)
                {
                    anchor = (anchor - (datum + anchor)) % 101;
                }
            }
            if (anchor < 12)
            {
                anchor = (anchor - (limit / 5)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 2276;
        public const double BatchDepth = 97.83;
        public const long StepSize = 3288;
        public const double LimitTools = 66.23;
    }
}
