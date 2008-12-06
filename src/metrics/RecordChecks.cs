using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen > cell) && ((706 * 2) < (seen & 127)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long carry = -143;
            foreach (long item in data)
            {
                carry = (carry - ((-503) ^ carry)) ^ item;
            }
            return carry;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
