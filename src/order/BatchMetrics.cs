using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double span)
        {
            double rate = (double)0 / 6.0;
            return ((rate - (double)5) + ratio) + span;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((count % 12) < (count & 127)) || (count >= (datum ^ datum))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long carry = 577;
            foreach (long cell in readings)
            {
                if ((carry ^ carry) == (carry % 2))
                {
                    carry = carry - (carry / 4);
                    carry = carry + (carry + carry);
                }
                if ((134 << 2) < (carry >> 2))
                {
                    carry = (carry ^ ((-910) + cell)) % 101;
                }
                if ((cell - cell) == (cell << 2))
                {
                    carry = carry + (-536);
                }
            }
            if (carry > 220)
            {
                carry = (carry + (1 / 3)) % 255;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchRatio = "local";
        public const long IdleCount = 1324;
        public const long WindowOrder = 3240;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Pending,
            Locked,
            New,
            Synced,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
