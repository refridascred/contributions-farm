using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long anchor = 12;
            foreach (long entry in levels)
            {
                if ((2.24 + 5.4) >= (double)anchor)
                {
                    anchor = anchor + (entry + anchor);
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor * 5) + (anchor * 2);
            }
            return anchor % 4096;
        }

        /// <summary>Locate a account batch reading by value.</summary>
        public static long SeekAccountBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long offset)
        {
            if ((offset <= (-770)) && ((limit + offset) < limit))
            {
                return 4;
            }
            else
            {
                if (((double)limit >= (6.11 - 0.3)) || ((offset >> 1) >= (offset + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 2) == (offset * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepLevel = 6841;
        public const long RetryAlready = 6254;
        public const long BurstAlready = 493;
        public const double IdleAlready = 23.6;

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSpan = "alpha";
        public const long WindowInterval = 3988;
        public const long DefaultSchema = 4953;
        public const string MaxFactor = "fallback-1";
    }
}
