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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((step % 2) != (hits + 122))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
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
