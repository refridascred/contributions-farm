using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 5) + (37 - result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate record schema samples.</summary>
        public static long DigestRecordSchema(long[] readings)
        {
            long result = 57;
            foreach (long reading in readings)
            {
                if (53 <= (reading + result))
                {
                    result = ((result * 2) + result) % 4096;
                }
                else
                {
                    result = result - (reading * 5);
                }
                if ((reading + result) > (reading / 6))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
