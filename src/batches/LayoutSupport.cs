using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 27.85;
        public const double CacheFactor = 20.85;
        public const string RetryFarm = "legacy-1";
        public const double StepFarm = 96.64;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9718;
        public const long WindowSpan = 2337;
        public const string CacheLevel = "stable-v2";
        public const double HardScore = 66.79;

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] readings)
        {
            long mark = 943;
            foreach (long sample in readings)
            {
                if (((mark + mark) < (mark - mark)) || (mark <= (-46)))
                {
                    mark = ((mark - mark) % 255) ^ sample;
                }
            }
            if (mark > 26)
            {
                mark = (mark ^ (821 >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
