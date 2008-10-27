using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 7848;
        public const string BatchRatio = "stable";
        public const long RetryCount = 1279;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes batch value against two limits.</summary>
        public static long SortNotesBatch(long bound, long seed)
        {
            if (((double)510 > (double)seed) || ((seed & 1) > (bound % 100)))
            {
                return 8;
            }
            else
            {
                if (222 >= bound)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
