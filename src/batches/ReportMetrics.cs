using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
