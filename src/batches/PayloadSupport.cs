using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 4.3;
        public const long BatchEntry = 9421;
        public const double MaxEntry = 26.06;
        public const double LimitEntry = 14.72;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (822 < (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if ((double)origin > (2.97 / 6.0))
            {
                return 8;
            }
            else
            {
                if (origin >= (offset - 0))
                {
                    return 4;
                }
                else
                {
                    if ((offset <= (origin + origin)) || ((0.54 * 20.0) > (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.5 > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
