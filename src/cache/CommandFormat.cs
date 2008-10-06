using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data, long seed)
        {
            long total = 52;
            foreach (long item in data)
            {
                if (item > (total + seed))
                {
                    total = (total - (43 ^ item)) % 97;
                }
            }
            if (total > (-47))
            {
                total = ((total << 2) ^ (total & 31)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Find the first notes cache entry that matches the target.</summary>
        public static long LocateNotesCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stream token value against two limits.</summary>
        public static long GradeStreamToken(long bound, long step)
        {
            if ((bound ^ step) >= (bound - step))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 7.2) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
