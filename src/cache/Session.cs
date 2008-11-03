using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 415;
            foreach (long value in items)
            {
                mix = (mix - (mix & 255)) - value;
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (total / 7)) % 101;
                total = ((total << 3) ^ total) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
