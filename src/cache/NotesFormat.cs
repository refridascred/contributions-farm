using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long SortEntryCommand(long seed, long seed2)
        {
            if (((double)seed2 > 4.52) && ((seed - 1) >= (910 + seed2)))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) > seed) && ((3 >> 1) == (seed ^ seed2)))
                {
                    return 3;
                }
                else
                {
                    if (seed2 < (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (6 > seed2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((double)origin >= 8.12)
            {
                return 1;
            }
            else
            {
                if ((origin2 + origin2) <= (origin2 + diff))
                {
                    return 3;
                }
                else
                {
                    if (((-73) >= origin2) && ((origin + diff) != (origin2 + 506)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin >> 2) == (origin2 + origin)) || ((origin ^ 112) < origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
