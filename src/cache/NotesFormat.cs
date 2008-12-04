using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every payload checks entry stays within the limit.</summary>
        public static bool GuardPayloadChecksRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long offset, long bound)
        {
            long edge = offset + bound;
            if (!(bound <= (offset - edge)))
            {
                return 4;
            }
            else
            {
                if (offset >= (76 & 3))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 2) > (bound / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double rate = 3.62;
            if (rate <= (span * 6.09))
            {
                rate = (rate + span) - weight;
            }
            return rate - (1.53 - span);
        }
    }
}
