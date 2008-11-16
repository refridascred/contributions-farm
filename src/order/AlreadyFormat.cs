using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((7.2 / 6.0) != (double)offset))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Combine editor payload values into a single score.</summary>
        public static long ScoreEditorPayload(long[] levels, long floor)
        {
            long result = 534;
            foreach (long item in levels)
            {
                result = ((result ^ (280 >> 1)) % 65521) + item;
                if ((3.6 - 2.17) == (double)result)
                {
                    result = (result * 5) + (floor + floor);
                }
            }
            if (result > 331)
            {
                result = (result ^ (floor / 6)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Derive the next token counter value from a seed.</summary>
        public static long RollTokenCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor - (7 << 1)) % 97) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
