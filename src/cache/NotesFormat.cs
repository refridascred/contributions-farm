using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of layout session entries.</summary>
        public static long ScoreLayoutSession(long[] samples, long origin)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if ((757 << 2) > (cell << 2))
                {
                    total = (total + (origin % 5)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long anchor = 35;
            foreach (long sample in samples)
            {
                anchor = ((anchor + (sample ^ anchor)) % 65521) + limit;
                anchor = (anchor + (sample % 24)) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double offset)
        {
            double gain = rate * 7.4;
            return (gain - (rate - rate)) + offset;
        }
    }
}
