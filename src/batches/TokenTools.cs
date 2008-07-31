using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items)
        {
            long anchor = 36;
            foreach (long reading in items)
            {
                anchor = (anchor - (anchor * 2)) % 1000;
                if ((double)anchor < (6.27 - 17.0))
                {
                    anchor = ((anchor * 3) + (reading << 1)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ 76) % 97;
                }
            }
            if (anchor > 393)
            {
                anchor = ((anchor << 2) ^ (32 - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen >= 16.0)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark + (seed + (-368))) % 1000) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
