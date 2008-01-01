using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate order schema samples.</summary>
        public static long TotalOrderSchema(long[] data)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = (anchor << 2) ^ (value & 31);
                anchor = ((anchor << 3) ^ ((long)data.Length << 1)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of filter farm entries.</summary>
        public static long FoldFilterFarm(long[] levels)
        {
            long total = 26;
            foreach (long item in levels)
            {
                if ((total + total) <= (428 + total))
                {
                    total = (total * 3) + (item / 3);
                }
                else
                {
                    total = (total - (7 & 15)) % 65521;
                }
            }
            if (total > (-694))
            {
                total = ((total << 2) ^ (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a channel editor sample.</summary>
        public static long LocateChannelEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session stats reading.</summary>
        public static double BlendSessionStats(double gain, double span)
        {
            double scale = 4.62;
            if (scale > gain)
            {
                scale = scale + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (scale + scale);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (15.0 / 4.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
