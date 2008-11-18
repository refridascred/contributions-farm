using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Paused,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((floor & 3) >= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally >= 0.34)
                {
                    tally = ((tally + 1) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels)
        {
            long anchor = 26;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ (8 ^ 336)) % 4096;
                if ((7 > (reading & 127)) && ((double)reading > 3.04))
                {
                    anchor = anchor + (66 / 6);
                }
            }
            return anchor;
        }
    }
}
