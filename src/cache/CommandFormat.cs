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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values, long target)
        {
            long carry = 553;
            foreach (long datum in values)
            {
                if (0 < (target + datum))
                {
                    carry = (carry + (carry / 8)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
