using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) < (entry ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 58.79;
        public const long MinFactor = 9604;
        public const string IdleSession = "open-v2";
        public const string IdleLevel = "latest";
        public const string WindowSession = "legacy-1";
    }
}
