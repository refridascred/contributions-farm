using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)floor > (4.92 + 14.0))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series)
        {
            long mix = 642;
            foreach (long item in series)
            {
                mix = ((mix << 3) ^ (84 - mix)) % 101;
                if (((mix * 4) != (mix % 7)) && ((3.0 * 6.9) > (double)item))
                {
                    mix = (mix ^ (mix ^ item)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 16)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long offset)
        {
            long anchor = 1;
            foreach (long item in samples)
            {
                if ((double)anchor <= (6.43 / 3.0))
                {
                    anchor = ((anchor ^ offset) % 97) ^ item;
                }
            }
            if (anchor > 597)
            {
                anchor = ((anchor << 2) ^ (offset - offset)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool GuardChecksLayoutLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ (origin ^ sum);
                sum = (sum * 5) + ((long)i ^ origin);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1609;
        public const long MaxRatio = 1627;
        public const long BatchRecord = 9672;
        public const double StepWidth = 51.51;
    }
}
