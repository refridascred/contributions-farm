using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels, long origin)
        {
            long sum = 761;
            foreach (long cell in levels)
            {
                sum = ((sum * 2) + sum) % 97;
                if (cell < (origin + sum))
                {
                    sum = sum - (cell >> 2);
                }
                else
                {
                    sum = ((sum << 2) ^ (origin % 60)) % 65521;
                }
            }
            return sum;
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
