using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels)
        {
            long mark = 858;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - (mark ^ mark)) % 255) + (long)i;
                    mark = mark ^ (value + mark);
                }
                mark = mark - (40 & 63);
            }
            if (mark > 347)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Project the next filter window value.</summary>
        public static double SmoothFilterWindow(double scale, double floor)
        {
            double load = (double)((-613) ^ 2);
            if (load > (double)0)
            {
                load = ((load - (double)9) - scale) - floor;
            }
            return load + (6.75 / 7.0);
        }

        /// <summary>Combine window entry values into a single score.</summary>
        public static long ScoreWindowEntry(long[] data, long seed)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((state ^ reading) != (seed << 3))
                {
                    state = (state << 2) ^ 612;
                }
            }
            return state;
        }
    }
}
