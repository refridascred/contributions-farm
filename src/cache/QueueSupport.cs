using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window batch readings against a rule.</summary>
        public static long MeasureWindowBatchOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((0.4 - 9.28) >= (double)datum)
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + 6) % 255;
                if ((seed - sum) >= (62 % 64))
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
                sum = (sum ^ 752) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)origin == (3.0 / 5.0))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
