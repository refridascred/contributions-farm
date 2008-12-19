using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format layout counter forward.</summary>
        public static long DeriveFormatLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result + ((long)i / 5)) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - seen) >= seen)
                {
                    seen = ((seen + 1) + value) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
