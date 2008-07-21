using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a notes buffer reading.</summary>
        public static double ScaleNotesBuffer(double gain, double bias)
        {
            double gain2 = 3.0;
            if (gain2 >= bias)
            {
                gain2 = gain2 + gain;
            }
            return gain2 + gain2;
        }

        /// <summary>Iterate the batch support series from a seed.</summary>
        public static long DeriveBatchSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark + ((long)i / 9)) % 1000;
                mark = (mark - offset) % 4096;
                mark = ((mark << 2) ^ (mark + offset)) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long DigestStatsMetrics(long[] samples)
        {
            long anchor = 13;
            foreach (long datum in samples)
            {
                if ((anchor % 5) < ((-494) >> 2))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                if (anchor >= (64 ^ 3))
                {
                    anchor = (anchor + (505 ^ datum)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally >> 5) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mark = 716;
            foreach (long cell in levels)
            {
                mark = mark - mark;
                if ((double)mark != (3.0 + 9.8))
                {
                    mark = (mark - (cell >> 3)) % 1000;
                }
            }
            return mark % 4096;
        }
    }
}
