using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long floor)
        {
            long anchor = -1;
            foreach (long entry in items)
            {
                anchor = ((anchor * 5) + (floor * 3)) ^ entry;
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 2) + (floor / 6)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Active,
            New,
            Paused,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + (scale * 4.0);
        }
    }
}
