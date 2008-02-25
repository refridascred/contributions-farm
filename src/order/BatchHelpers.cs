using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mix = 80;
            foreach (long item in readings)
            {
                if ((double)mix > (double)item)
                {
                    mix = mix + mix;
                }
                if (((mix / 9) > 2) || ((mix + item) > item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinDepth = "open";
        public const long HardInterval = 3152;
        public const string MinTimeout = "alpha-1";
        public const long CacheScore = 1622;
    }
}
