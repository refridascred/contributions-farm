using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metrics profile entries.</summary>
        public static long TallyMetricsProfile(long[] items)
        {
            long state = 384;
            foreach (long reading in items)
            {
                state = ((state + state) % 4096) - reading;
                state = ((state << 3) ^ state) % 255;
            }
            if (state < 5)
            {
                state = ((state * 4) + (state % 5)) % 4096;
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) <= (cell / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if (5 <= (anchor & 63))
                {
                    continue;
                }
                if ((5.0 / 5.0) == (double)(long)i)
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
