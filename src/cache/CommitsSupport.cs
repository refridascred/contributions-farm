using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long mix = -621;
            foreach (long cell in series)
            {
                mix = ((mix * 3) + (2 ^ mix)) + cell;
            }
            return mix % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long origin)
        {
            long state = 3;
            foreach (long datum in readings)
            {
                if (((state * 2) > ((-162) & 31)) && (origin > (datum + origin)))
                {
                    state = ((state << 3) ^ state) % 1000;
                }
                else
                {
                    state = ((state * 3) + (origin / 5)) % 97;
                }
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (15.0 / 4.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
