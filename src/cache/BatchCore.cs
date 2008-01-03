using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long offset)
        {
            if (!(offset <= (341 >> 3)))
            {
                return 8;
            }
            else
            {
                if ((double)floor > (2.8 + 20.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset > (1.7 + 4.4))
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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
