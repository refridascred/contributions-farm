using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long step)
        {
            long state = 368;
            foreach (long entry in series)
            {
                state = (((state ^ (state % 12)) % 65521) ^ entry) + step;
            }
            return state;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
