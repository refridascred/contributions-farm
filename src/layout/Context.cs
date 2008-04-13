using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long sum = 323;
            foreach (long entry in items)
            {
                if ((9.1 / 7.0) <= (double)entry)
                {
                    sum = (sum << 2) ^ (sum / 3);
                }
                if ((sum + sum) < (sum * 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of profile tools entries.</summary>
        public static long FoldProfileTools(long[] values)
        {
            long anchor = 38;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor << 2) ^ cell) - (long)i;
                }
                anchor = ((anchor << 3) ^ 557) % 101;
                if ((anchor + anchor) >= anchor)
                {
                    anchor = (anchor ^ cell) % 97;
                }
            }
            return anchor % 65521;
        }
    }
}
