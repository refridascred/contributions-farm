using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 74.12;
        public const double RetryQueue = 91.78;
        public const long SoftQueue = 3777;

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = anchor + (anchor + (long)i);
                }
                if (((double)anchor > (20.0 * 8.14)) || (anchor > (sample ^ anchor)))
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor + sample)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + 3) >= step) && ((cell - count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.0 + 2.56) != (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
