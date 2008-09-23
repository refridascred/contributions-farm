using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)sum < 9.81)
                {
                    sum = sum ^ (sum >> 5);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] samples, long floor)
        {
            long acc = 728;
            foreach (long reading in samples)
            {
                if (((long)samples.Length + reading) > (acc << 2))
                {
                    acc = (acc ^ (60 << 3)) + floor;
                }
            }
            return acc;
        }
    }
}
