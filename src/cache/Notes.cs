using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long seed)
        {
            if ((3.11 * 6.41) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((offset * 3) >= seed)
                {
                    return 6;
                }
                else
                {
                    if (!((seed % 10) < (offset ^ seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)20 <= (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 6473;
        public const string MaxFactor = "cached-v2";
        public const long WindowScore = 8370;
        public const string RetrySpan = "open-edge";
    }
}
