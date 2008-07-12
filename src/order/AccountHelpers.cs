using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long CountNotesAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((item >> 5) != (hits + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up filter channel samples.</summary>
        public static long CompareFilterChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits <= (double)(-8))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer batch reading by value.</summary>
        public static long FindBufferBatchIndex(long[] readings, long origin)
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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "standard-1";
        public const double BaseWidth = 24.99;
        public const long DefaultCount = 9337;
    }
}
