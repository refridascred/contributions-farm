using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 3637;
        public const long BaseNotes = 6425;
        public const string BaseDepth = "primary-v2";

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long anchor = 389;
            foreach (long datum in samples)
            {
                if ((datum + (-269)) < datum)
                {
                    anchor = ((anchor * 2) + (datum * 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (8 / 9)) % 97;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                state = (state << 3) ^ (state ^ seed);
                if (((sample << 2) <= state) || ((sample & 3) == (sample + state)))
                {
                    break;
                }
            }
            if (state < 80)
            {
                state = state ^ (state << 2);
            }
            return state;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
