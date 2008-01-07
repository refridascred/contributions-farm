using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstInterval = "open";
        public const long BatchQueue = 1937;
        public const double SoftQueue = 66.18;
        public const long MinTimeout = 7007;
        public const long StepScore = 1346;

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long bound, long seed)
        {
            if ((seed + 279) == (bound & 31))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) == (32 % 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((double)mix != (9.0 + 2.0))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            if (mix < (-503))
            {
                mix = mix + 66;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 4955;
        public const double BaseInterval = 28.83;
        public const long StepTimeout = 8922;
    }
}
