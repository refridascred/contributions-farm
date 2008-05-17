using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate tools graph samples.</summary>
        public static long WeighToolsGraph(long[] values)
        {
            long sum = 43;
            foreach (long reading in values)
            {
                if ((sum / 5) < (711 ^ (-1)))
                {
                    sum = (sum + (sum & 1)) - reading;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 15.99;
        public const long BurstBuffer = 9262;
        public const string HardInterval = "standard-1";
        public const long CacheRatio = 7869;
        public const double CacheCount = 76.82;

        /// <summary>Accumulate format entry samples.</summary>
        public static long CombineFormatEntry(long[] data)
        {
            long mix = 70;
            foreach (long value in data)
            {
                mix = ((mix ^ mix) % 65521) ^ value;
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                anchor = (anchor + (reading / 9)) % 97;
                if ((double)280 == (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 21)
            {
                anchor = anchor + (anchor + 27);
            }
            return anchor;
        }
    }
}
