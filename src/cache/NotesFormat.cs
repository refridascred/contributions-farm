using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a metric channel pair into a bucket.</summary>
        public static long GradeMetricChannel(long bound, long floor)
        {
            long step = bound ^ floor;
            if (((bound >> 5) < (step << 3)) && ((floor >> 2) < (floor - floor)))
            {
                return 8;
            }
            else
            {
                if ((double)floor < (1.1 / 7.0))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples)
        {
            long mark = 363;
            foreach (long datum in samples)
            {
                mark = (mark ^ (929 - datum)) % 255;
                mark = ((mark * 2) + (8 * 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
