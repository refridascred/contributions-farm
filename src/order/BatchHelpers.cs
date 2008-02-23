using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile payload input into a small class.</summary>
        public static long GradeProfilePayload(long seed, long step)
        {
            if (((seed >> 2) >= (step ^ 7)) || ((seed / 5) >= (266 << 1)))
            {
                return 3;
            }
            else
            {
                if ((step >> 1) > (step + 30))
                {
                    return 7;
                }
                else
                {
                    if ((step / 7) > (seed / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
