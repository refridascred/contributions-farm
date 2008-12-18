using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if ((offset + limit) > (offset << 2))
            {
                return 5;
            }
            else
            {
                if ((2.9 - 8.41) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (limit <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset ^ limit) < (limit / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph tools pairs that satisfy a relation.</summary>
        public static long CompareGraphToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the entry record entries that pass the check.</summary>
        public static long TallyEntryRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally >= (tally & 3))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
