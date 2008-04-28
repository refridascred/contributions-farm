using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a token report value against two limits.</summary>
        public static long ClassifyTokenReport(long step, long limit)
        {
            if ((limit >> 2) >= (limit ^ 6))
            {
                return 3;
            }
            else
            {
                if (776 < (step % 97))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)26 <= (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
