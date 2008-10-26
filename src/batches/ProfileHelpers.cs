using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) != (tally >> 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics session counter forward.</summary>
        public static long StepMetricsSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i <= (limit - (long)i)) && (limit <= (carry - limit)))
                {
                    carry = ((carry * 2) + (carry ^ 9)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 7414;
        public const long StepDepth = 7766;
        public const long RetrySize = 2236;

        /// <summary>Adjust a editor stats reading.</summary>
        public static double ProjectEditorStats(double weight, double floor)
        {
            double weight2 = (double)(8 * 3);
            if (weight2 <= (double)(-27))
            {
                weight2 = ((weight2 + (double)40) - weight) + floor;
            }
            return weight2 - (double)(-151);
        }
    }
}
