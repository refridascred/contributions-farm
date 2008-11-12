using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up cluster checks samples.</summary>
        public static long MatchClusterChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two editor stream measurements.</summary>
        public static double SmoothEditorStream(double weight, double span)
        {
            double scale = (weight / 6.0) / 4.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (weight + 9.01)) - (double)(long)i) - span;
            }
            return scale + (double)1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long BucketFarmWindow(long offset, long limit)
        {
            if (!((19.0 / 2.0) != (double)limit))
            {
                return 1;
            }
            else
            {
                if ((3.2 / 2.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset >= (5.37 * 6.3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset <= (5.0 / 6.0)) && (offset <= (offset - 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
