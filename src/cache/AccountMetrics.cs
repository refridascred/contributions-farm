using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of support command entries.</summary>
        public static long FoldSupportCommand(long[] items, long offset)
        {
            long anchor = 5;
            foreach (long cell in items)
            {
                anchor = (anchor - (offset << 1)) - cell;
            }
            if (anchor < 925)
            {
                anchor = (anchor ^ ((long)items.Length & 15)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum & 15) >= 613)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph cluster reading.</summary>
        public static double ScaleGraphCluster(double scale, double span)
        {
            double scale2 = span;
            if (scale2 > 6.49)
            {
                scale2 = scale2 - scale;
            }
            return scale2 + 1.1;
        }

        /// <summary>Digest a series of window queue entries.</summary>
        public static long CombineWindowQueue(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = anchor - (entry ^ entry);
            }
            return anchor;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchWidth = "primary-edge";
        public const long DefaultBatch = 7927;
        public const string WindowBatch = "latest-edge";
    }
}
