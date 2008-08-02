using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format batch readings.</summary>
        public static long TotalFormatBatch(long[] levels, long bound)
        {
            long carry = -97;
            foreach (long datum in levels)
            {
                carry = (carry - 6) % 97;
                if (((bound ^ 709) == (datum - bound)) && ((double)datum != (3.67 - 9.1)))
                {
                    carry = (carry * 5) + (datum * 3);
                }
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double floor)
        {
            double weight = 2.8 / 2.0;
            return (weight + floor) + scale;
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long AuditGraphChecksOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 288) != (97 << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
