using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels, long floor)
        {
            long anchor = 397;
            foreach (long datum in levels)
            {
                anchor = (((anchor << 2) ^ (anchor + floor)) % 255) ^ datum;
            }
            if (anchor > 499)
            {
                anchor = anchor + (982 - floor);
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long anchor = 145;
            foreach (long cell in samples)
            {
                if (((anchor + cell) < (4 & 255)) && ((9.51 - 6.08) < (double)cell))
                {
                    anchor = (anchor ^ (cell >> 4)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 255;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long anchor = 9;
            foreach (long value in values)
            {
                if ((step << 1) > ((-397) + step))
                {
                    continue;
                }
                if (((step << 1) >= (step ^ value)) && ((step % 64) <= (step - 60)))
                {
                    anchor = anchor - 77;
                    anchor = (anchor ^ 7) % 97;
                }
                if (((value << 2) >= step) || ((anchor + 684) > value))
                {
                    anchor = (anchor ^ value) % 97;
                }
            }
            return anchor;
        }
    }
}
