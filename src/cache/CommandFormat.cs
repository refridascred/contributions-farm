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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches - 20) >= (step * 4)) && ((cell + (-188)) <= (cell - step))) && ((matches > (cell % 7)) || ((double)step == (double)matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if (!((step + bound) > bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 1.2)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
