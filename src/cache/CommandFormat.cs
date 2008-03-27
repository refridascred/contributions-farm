using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first layout checks entry that matches the target.</summary>
        public static long FindLayoutChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record command readings.</summary>
        public static long TallyRecordCommand(long[] readings, long target)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                carry = ((carry * 5) + ((long)readings.Length << 3)) % 97;
                carry = (carry ^ cell) % 4096;
            }
            if (carry < 52)
            {
                carry = (carry * 3) + (target * 2);
            }
            return carry % 65521;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route notes entry stays within the limit.</summary>
        public static bool ValidateRouteNotesRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
