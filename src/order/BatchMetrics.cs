using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((-7) - count) < (item + count)) && !(item > (count + item)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
