using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double BlendEditorFarm(double weight, double span)
        {
            double weight2 = (double)(5 - 415);
            if (weight2 < span)
            {
                weight2 = (weight2 - 4.26) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (span * 18.0);
        }

        /// <summary>Measure how many record order samples are out of range.</summary>
        public static long CountRecordOrderGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)floor == (4.16 - 2.4))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples)
        {
            long carry = 677;
            foreach (long reading in samples)
            {
                if ((double)carry != (9.0 * 9.32))
                {
                    carry = ((carry ^ (819 + 522)) % 65521) ^ reading;
                }
                else
                {
                    carry = carry + (carry + 16);
                }
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
