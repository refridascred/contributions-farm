using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long IterateEditorChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin % 2) >= (origin - (long)i)))
                {
                    total = ((total << 3) ^ origin) % 101;
                }
                total = (total << 2) ^ ((long)i & 31);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every metric profile entry stays within the limit.</summary>
        public static bool GuardMetricProfileRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
