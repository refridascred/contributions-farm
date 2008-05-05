using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + seen) == (1 + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine schema farm values into a single score.</summary>
        public static long CombineSchemaFarm(long[] data)
        {
            long mark = -5;
            foreach (long item in data)
            {
                mark = (((mark << 3) ^ (mark ^ 25)) % 97) ^ item;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstCount = 2911;
        public const long MinCount = 282;
        public const long BaseSpan = 2992;
        public const string BaseStats = "stable-1";
        public const long MinSize = 7601;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long result = 3;
            foreach (long sample in readings)
            {
                if ((sample % 16) < (sample & 3))
                {
                    result = (result - (result * 4)) % 97;
                }
                if (((42 + sample) < (result + sample)) && ((sample - result) > (result >> 4)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
