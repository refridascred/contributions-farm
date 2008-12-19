using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long mix = 242;
            foreach (long cell in data)
            {
                if ((13.0 >= (double)cell) || ((6.5 + 0.4) >= (double)mix))
                {
                    mix = (mix << 3) ^ (mix * 5);
                }
            }
            if (mix < 48)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
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
