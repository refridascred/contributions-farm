using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Ready,
            Stale,
            Pending,
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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
