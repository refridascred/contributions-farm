using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double floor)
        {
            double ratio = floor;
            return (ratio - (double)847) + rate;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series, long floor)
        {
            long total = 0;
            foreach (long cell in series)
            {
                total = (total + (cell << 3)) % 255;
                if ((cell - floor) < (floor ^ cell))
                {
                    break;
                }
            }
            if (total > 85)
            {
                total = (total ^ (total % 3)) % 65521;
            }
            return total % 65521;
        }
    }
}
