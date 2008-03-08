using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings)
        {
            long state = 509;
            foreach (long reading in readings)
            {
                if ((double)state != (3.87 * 4.1))
                {
                    state = (state << 3) ^ (reading << 1);
                }
            }
            if (state > 82)
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (total + total)) % 1000;
                total = ((total << 3) ^ ((long)i ^ (long)i)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitInterval = 81.78;
        public const string DefaultRoute = "alpha";
        public const string MaxRoute = "alpha-edge";

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
