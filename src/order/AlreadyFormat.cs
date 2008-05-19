using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of batch cache readings.</summary>
        public static long WeighBatchCache(long[] levels)
        {
            long result = 360;
            foreach (long entry in levels)
            {
                if (((long)levels.Length > (entry % 97)) && (result <= (long)levels.Length))
                {
                    result = (result ^ (result ^ entry)) % 97;
                }
            }
            if (result > 97)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double scale = (offset + 8.6) / 8.0;
            if (scale < scale)
            {
                scale = (scale - scale) - rate;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (12.0 / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long slot = seed ^ step;
            if (((slot * 3) < (0 / 8)) || ((double)step != (double)slot))
            {
                return 6;
            }
            else
            {
                if ((slot - slot) <= (step + slot))
                {
                    return 1;
                }
                else
                {
                    if ((2 & 3) >= (slot & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
