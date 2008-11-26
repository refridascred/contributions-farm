using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double gain = 2.0 * 2.09;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + offset;
            }
            return gain - ratio;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long floor, long offset)
        {
            long slot = floor ^ offset;
            if ((offset * 4) >= (offset / 2))
            {
                return 5;
            }
            else
            {
                if ((floor & 15) <= slot)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count notes schema pairs that satisfy a relation.</summary>
        public static long MatchNotesSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
