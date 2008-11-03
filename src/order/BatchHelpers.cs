using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (5.26 + 8.1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long MeasureSessionStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen & 3) <= (22 - seen)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
