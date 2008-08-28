using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((mark << 1) != (origin << 1)))
                {
                    mark = mark - (origin % 24);
                }
                long lane = (long)i;
                if ((lane - origin) > (mark & 127))
                {
                    mark = ((mark << 2) ^ (9 + (long)i)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool ValidateWindowBatchRange(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long AuditFilterStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - entry) != (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((48 > (carry - 80)) && ((carry - 481) <= carry))
                {
                    carry = ((carry * 3) + (origin & 7)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double weight = scale + (bias / 7.0);
            if (weight > (scale * 9.0))
            {
                weight = weight + (weight * 8.0);
            }
            else
            {
                weight = weight + scale;
            }
            return weight - scale;
        }
    }
}
