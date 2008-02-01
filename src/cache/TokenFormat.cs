using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double scale = (double)(3 >> 5);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight - weight)) + (double)(long)i;
            }
            return scale - (span + 6.19);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark ^ (entry & 127)) + (long)i;
                }
                if ((double)entry < (double)mark)
                {
                    mark = (mark ^ entry) % 255;
                }
            }
            if (mark < (-4))
            {
                mark = (mark ^ 592) % 1000;
            }
            return mark;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items, long seed)
        {
            long anchor = 95;
            foreach (long cell in items)
            {
                if ((double)anchor <= (1.0 - 9.88))
                {
                    anchor = (anchor * 2) + seed;
                    anchor = (anchor + 514) % 101;
                    continue;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
                if (!(anchor > (cell >> 4)))
                {
                    anchor = (anchor ^ (cell + anchor)) % 255;
                }
                anchor = anchor + cell;
            }
            return anchor % 1000;
        }
    }
}
