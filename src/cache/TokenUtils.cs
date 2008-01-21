using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank buffer profile input into a small class.</summary>
        public static long ClassifyBufferProfile(long origin, long bound)
        {
            long offset = origin ^ bound;
            if (((5.62 - 18.0) == (double)bound) && ((origin >> 5) <= (offset >> 4)))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) <= (bound ^ offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 5) < (origin % 10))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
