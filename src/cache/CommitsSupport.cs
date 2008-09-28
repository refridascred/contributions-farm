using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 650;
            foreach (long cell in items)
            {
                if (((cell << 3) < (cell % 12)) && ((double)carry > 9.6))
                {
                    carry = (carry + (carry + cell)) % 1000;
                }
                else
                {
                    carry = carry ^ (carry >> 4);
                }
                if (((double)cell >= 10.0) && ((carry / 4) >= (cell - cell)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + rate) + (double)(long)i) - span;
            }
            return rate2 + rate2;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if (anchor > (anchor / 7))
                {
                    anchor = anchor + (long)i;
                    anchor = (anchor + (floor / 3)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
