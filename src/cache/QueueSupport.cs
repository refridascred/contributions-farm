using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format counter counter forward.</summary>
        public static long RollFormatCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry ^ (356 + (long)i)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of batch command readings.</summary>
        public static long ScoreBatchCommand(long[] levels)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = sum + (82 - value);
            }
            if (sum > 459)
            {
                sum = (sum + (sum << 3)) % 101;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)target >= 9.0)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
