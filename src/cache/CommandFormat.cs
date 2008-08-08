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

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ (total / 3)) % 255) + (long)i2;
                }
                total = ((total << 3) ^ ((long)i >> 5)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
