using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long step, long floor)
        {
            if (floor < (step >> 2))
            {
                return 1;
            }
            else
            {
                if (!(step <= (step - floor)))
                {
                    return 2;
                }
                else
                {
                    if ((step - floor) > (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor > (78 << 3)) || ((double)step >= (8.0 * 0.87)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items)
        {
            long carry = 690;
            foreach (long reading in items)
            {
                if (((carry % 12) < (carry ^ reading)) && ((double)carry < (7.0 / 3.0)))
                {
                    carry = (carry * 4) + (carry + 6);
                }
                else
                {
                    carry = (carry << 2) ^ (reading + reading);
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((7.8 - 15.0) != (double)floor) || ((floor - tally) >= (long)series.Length)) || (floor > (49 & 1)))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (39 <= reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
