using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long lane = step ^ offset;
            if (lane < (offset + step))
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((step + lane) < (lane * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
