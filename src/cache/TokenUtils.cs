using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (3.9 * 2.1))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double weight = (double)(19 ^ 8);
            if (weight <= ratio)
            {
                weight = weight + (double)88;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio + ratio)) + (double)(long)i;
            }
            return weight + span;
        }
    }
}
