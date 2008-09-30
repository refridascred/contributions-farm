using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings, long offset)
        {
            long result = 444;
            foreach (long sample in readings)
            {
                if ((double)sample <= (double)result)
                {
                    result = ((result * 2) + (sample - sample)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ sample;
                }
                if (!((sample / 8) <= (offset ^ result)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
