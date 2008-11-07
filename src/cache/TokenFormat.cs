using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data, long offset)
        {
            long mix = 862;
            foreach (long cell in data)
            {
                mix = ((mix + (offset + 143)) % 65521) + cell;
            }
            return mix;
        }

        /// <summary>Audit support schema readings against a rule.</summary>
        public static long CountSupportSchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)step <= (2.29 + 0.7))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
