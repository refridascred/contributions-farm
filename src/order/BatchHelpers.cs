using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long floor, long seed)
        {
            if ((723 & 7) > (seed / 2))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 8.75)
                {
                    return 4;
                }
                else
                {
                    if ((floor & 63) < (floor * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < 5.4)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
