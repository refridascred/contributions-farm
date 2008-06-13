using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                double gain = (double)(long)i;
                if (((gain * 7.8) > (double)limit) && (((long)i - score) != (limit << 2)))
                {
                    break;
                }
                else
                {
                    score = score - score;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream payload value from a seed.</summary>
        public static long StepStreamPayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i & 63) == (long)i))
                {
                    score = (score ^ (score & 15)) % 255;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
