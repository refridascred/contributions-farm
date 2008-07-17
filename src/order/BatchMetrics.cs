using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((total >> 1) < (total + 81)))
                {
                    total = ((total * 3) + (step * 4)) % 4096;
                }
                else
                {
                    total = (total - step) % 255;
                }
                total = ((total * 5) + total) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels, long origin)
        {
            long anchor = 160;
            foreach (long entry in levels)
            {
                anchor = (anchor - (origin / 7)) % 255;
                if ((((-620) / 9) <= (entry << 3)) || ((18.0 - 3.1) < (double)origin))
                {
                    anchor = (anchor + (anchor & 63)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if (((gap % 2) < (offset + (-435))) || ((gap << 2) > (gap >> 2)))
            {
                return 4;
            }
            else
            {
                if ((88 > (offset / 3)) && ((double)gap > (2.2 + 18.0)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values, long target)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ reading) % 65521;
            }
            if (anchor < 552)
            {
                anchor = (anchor ^ (target * 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LocateTokenBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
