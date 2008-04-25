using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 2089;
        public const string BaseRecord = "stable-1";
        public const string DefaultRatio = "fallback-v2";
        public const long LimitDepth = 2313;
        public const long BatchFactor = 1373;

        /// <summary>Match up buffer window samples.</summary>
        public static long CompareBufferWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long floor)
        {
            long acc = 3;
            foreach (long sample in series)
            {
                acc = ((acc << 2) ^ (sample + sample)) + floor;
                acc = ((acc * 4) + 975) % 101;
            }
            if (acc > 101)
            {
                acc = (acc << 3) ^ (acc >> 1);
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1300;
        public const long LimitCommand = 7284;
        public const long MinCommand = 4812;
        public const double BaseFactor = 25.7;
        public const long MaxCommand = 1980;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
