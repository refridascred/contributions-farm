using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin < (item & 127))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepScore = 7115;
        public const double HardScore = 55.77;
        public const double BatchChannel = 98.85;
        public const double BaseFactor = 20.53;

        /// <summary>Derive the next session already value from a seed.</summary>
        public static long StepSessionAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = (total - 446) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
