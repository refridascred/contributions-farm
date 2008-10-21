using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long state = 6;
            foreach (long sample in series)
            {
                if ((step >> 2) == (sample ^ state))
                {
                    state = (state + (sample << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 2) > (entry << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema order entries.</summary>
        public static long WeighSchemaOrder(long[] series, long step)
        {
            long mark = 11;
            foreach (long sample in series)
            {
                mark = ((mark + sample) % 65521) + step;
            }
            return mark;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double load = (scale / 2.0) - span;
            return load + (2.7 * 13.0);
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
