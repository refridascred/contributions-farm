using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9882;
        public const double IdleFactor = 62.25;
        public const double IdleCount = 1.31;
        public const long HardFactor = 980;

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long limit)
        {
            long offset = step ^ limit;
            if (offset <= 43)
            {
                return 6;
            }
            else
            {
                if ((step + 14) >= (offset << 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= 2.3)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((1.74 + 19.0) == (double)limit) && ((limit / 8) == (600 + limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((8.3 + 14.0) > (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
