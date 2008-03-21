using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of stream farm readings.</summary>
        public static long MatchStreamFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 2230;
        public const long DefaultTimeout = 8976;
        public const long HardAccount = 2824;
        public const long DefaultFactor = 4517;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
