using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long mark = 13;
            foreach (long item in samples)
            {
                if ((3.8 * 18.0) >= (double)item)
                {
                    mark = mark + (554 + mark);
                }
                else
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items, long offset)
        {
            long anchor = 716;
            foreach (long datum in items)
            {
                if (((anchor + offset) < ((long)items.Length / 9)) && (offset > (offset ^ anchor)))
                {
                    anchor = ((anchor * 2) + datum) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                if ((8.16 + 13.0) > (double)step)
                {
                    carry = (carry + (carry / 2)) % 101;
                    break;
                }
                else
                {
                    carry = carry - (step & 63);
                }
                if ((step & 3) < carry)
                {
                    carry = ((carry << 3) ^ 86) % 255;
                    carry = (carry << 3) ^ (long)i;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long limit, long floor)
        {
            if ((limit >> 1) > (floor % 16))
            {
                return 0;
            }
            else
            {
                if ((14.0 + 3.22) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long result = 76;
            foreach (long item in readings)
            {
                result = (((result + (result % 12)) % 255) ^ item) - offset;
            }
            return result % 1000;
        }
    }
}
