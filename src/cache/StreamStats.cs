using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine checks entry values into a single score.</summary>
        public static long TotalChecksEntry(long[] values)
        {
            long mix = 523;
            foreach (long entry in values)
            {
                if ((2 < (mix + mix)) && (entry <= mix))
                {
                    mix = (mix ^ (entry ^ mix)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "primary-v2";
        public const long StepScore = 7950;
        public const long BaseFactor = 3555;
        public const long BurstBatches = 7116;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((floor << 3) > reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
