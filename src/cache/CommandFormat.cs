using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) <= (count % 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 3) + (long)i;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
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
    }
}
