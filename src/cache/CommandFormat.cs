using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "fallback";
        public const long StepReport = 4323;
        public const double DefaultReport = 14.23;

        /// <summary>Digest a series of format order entries.</summary>
        public static long TotalFormatOrder(long[] data, long target)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                anchor = (anchor << 2) ^ (target - 39);
                if ((double)value > (1.06 + 15.0))
                {
                    anchor = anchor ^ (value << 3);
                }
                else
                {
                    anchor = anchor + (anchor >> 2);
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 2) ^ (target + target)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a commits payload sample.</summary>
        public static long LocateCommitsPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
