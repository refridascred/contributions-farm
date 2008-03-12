using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (794 % 100)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (matches <= (matches % 3))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] series)
        {
            long anchor = 7;
            foreach (long reading in series)
            {
                long seen = anchor - reading;
                if (((double)reading > (10.0 / 9.0)) && ((seen - anchor) == (reading + seen)))
                {
                    anchor = (anchor * 5) + (anchor ^ anchor);
                }
                anchor = anchor - (anchor * 4);
            }
            if (anchor > 98)
            {
                anchor = (anchor * 3) + (anchor >> 1);
            }
            return anchor % 1000;
        }
    }
}
