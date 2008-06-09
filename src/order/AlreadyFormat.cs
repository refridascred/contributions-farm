using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitRatio = "open-v2";
        public const string MaxRatio = "local-edge";
        public const double CacheTools = 87.9;
        public const long BatchInterval = 9310;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if (mark > (cell - mark))
                {
                    mark = mark + cell;
                }
                else
                {
                    mark = (mark + (mark / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!(state > (8 >> 3)))
                {
                    state = (state << 3) ^ (offset - state);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchSpan = "alpha-edge";
        public const string BatchRatio = "stable";
        public const long LimitCache = 1803;
        public const long DefaultCache = 4428;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long seed)
        {
            long offset = origin - seed;
            if ((double)400 > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((5.06 - 3.87) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset <= 424) || ((offset + origin) >= (offset + (-3))))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
