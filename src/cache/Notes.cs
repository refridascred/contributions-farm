using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Active,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (result ^ (long)i)) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((7.93 + 15.0) <= (double)entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
