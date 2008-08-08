using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the farm filter entries that pass the check.</summary>
        public static long CountFarmFilterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((step + item) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item >> 4) <= (54 ^ count)) && ((step - count) > (-1))) && ((double)item >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches < (5.02 + 3.7))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count command cluster pairs that satisfy a relation.</summary>
        public static long MatchCommandClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
