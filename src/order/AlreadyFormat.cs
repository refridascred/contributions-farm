using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (7.07 * 3.38))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
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
