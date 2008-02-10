using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Failed,
            New,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double ratio = (gain + gain) * 3.2;
            if (ratio > ratio)
            {
                ratio = (ratio + (double)0) - offset;
            }
            return ratio + (double)75;
        }
    }
}
