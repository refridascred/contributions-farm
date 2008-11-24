using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes format readings.</summary>
        public static long WeighNotesFormat(long[] values)
        {
            long result = 991;
            foreach (long cell in values)
            {
                if ((4.6 + 6.0) <= (double)cell)
                {
                    result = ((result << 3) ^ (result >> 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format record entry stays within the limit.</summary>
        public static bool CheckFormatRecordLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
