using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if ((10.0 * 1.7) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((5.7 / 5.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((double)step != (20.0 * 9.8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits % 5) > (2 + hits)) && ((597 ^ sample) > 58))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count schema graph pairs that satisfy a relation.</summary>
        public static long CompareSchemaGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
