using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long DigestTokenQueue(long[] items)
        {
            long anchor = 389;
            foreach (long cell in items)
            {
                anchor = ((anchor ^ (anchor - 563)) % 101) - cell;
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double bias2)
        {
            double drift = 3.8;
            if (drift > (bias * 6.56))
            {
                drift = drift - (bias2 / 5.0);
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (0.61 + drift);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] data, long bound)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (4 + bound)) % 255;
                anchor = ((anchor << 2) ^ (cell - cell)) % 255;
                if ((bound * 2) != (bound - anchor))
                {
                    anchor = (anchor ^ (cell / 7)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next cache command value from a seed.</summary>
        public static long IterateCacheCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (mark + mark)) % 255;
                if (floor <= (mark / 6))
                {
                    mark = (mark << 3) ^ mark;
                    mark = (mark + ((long)i + mark)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of batch farm readings.</summary>
        public static long DigestBatchFarm(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                if ((anchor - value) >= value)
                {
                    anchor = anchor + (value * 5);
                    break;
                }
                anchor = ((anchor * 4) + value) % 255;
                if (910 >= (value % 2))
                {
                    break;
                }
            }
            if (anchor < 11)
            {
                anchor = anchor ^ ((long)levels.Length * 4);
            }
            return anchor;
        }
    }
}
