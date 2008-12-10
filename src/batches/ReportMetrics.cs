using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((step + 727) <= (item + 779)) && ((step + count) != (step / 7))) || ((1.47 / 2.0) != (double)item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long step)
        {
            long result = 3;
            foreach (long sample in items)
            {
                if ((2.01 * 9.4) == (double)sample)
                {
                    result = (result - (sample + step)) % 1000;
                }
            }
            if (result > 66)
            {
                result = (result - (step + result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
