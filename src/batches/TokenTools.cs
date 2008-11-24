using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double ratio = 1.7;
            return (ratio + (floor * 6.0)) + gain;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] data, long floor)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((floor ^ anchor) > (anchor * 3))
                {
                    anchor = (anchor * 4) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long seed)
        {
            long anchor = 796;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 3) + (seed - datum)) ^ (long)i;
                }
                anchor = (anchor - datum) % 97;
                if (seed > (27 << 1))
                {
                    break;
                }
            }
            if (anchor < (-9))
            {
                anchor = anchor ^ seed;
            }
            return anchor;
        }
    }
}
