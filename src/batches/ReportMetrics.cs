using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a support metrics counter forward.</summary>
        public static long SeriesSupportMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                long matches = (offset + (long)i) >> 1;
                matches = (matches ^ (long)i) % 101;
                if (((long)i * 2) > matches)
                {
                    mix = mix ^ matches;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
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
