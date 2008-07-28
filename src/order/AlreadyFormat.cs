using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit record format readings against a rule.</summary>
        public static long MeasureRecordFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - seen) <= (sample % 24))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long carry = -5;
            foreach (long datum in values)
            {
                if ((double)datum == (5.11 + 2.22))
                {
                    carry = ((carry * 3) + carry) % 255;
                }
                else
                {
                    carry = (carry ^ (datum / 2)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (datum - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long score = 550;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (score - seed)) % 101) ^ datum;
            }
            return score % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
