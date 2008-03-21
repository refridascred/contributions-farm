using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits < (8.0 / 3.0))
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if (target >= (total * 3))
                {
                    total = total ^ (total * 4);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long seed2)
        {
            if ((double)seed < (2.9 - 0.2))
            {
                return 4;
            }
            else
            {
                if (!((double)seed != (double)28))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 5) >= (seed & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (double)(-6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] levels, long floor)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                if ((double)sample != (14.0 - 3.0))
                {
                    carry = (((carry << 2) ^ (sample % 12)) % 101) - floor;
                }
            }
            return carry % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "stable-v2";
        public const long MinInterval = 6375;
        public const long IdleContext = 7491;
    }
}
