using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long next = offset ^ step;
            if (!(next < (offset & 3)))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= 19.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long offset)
        {
            long total = 543;
            foreach (long cell in items)
            {
                total = (((total * 4) + total) % 65521) - offset;
                if (((double)total < (double)(-68)) && ((cell % 16) != (cell * 3)))
                {
                    break;
                }
            }
            if (total < 87)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values)
        {
            long acc = 4;
            foreach (long cell in values)
            {
                if (cell < (cell - acc))
                {
                    acc = ((acc * 2) + (4 + cell)) % 65521;
                }
                if ((73 / 5) <= (acc + cell))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen >= (1.0 + 16.0))
                {
                    seen = ((seen + 2) + reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
