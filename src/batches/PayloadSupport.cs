using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) >= ((-9) * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi record input into a small class.</summary>
        public static long ClassifyContributiRecord(long offset, long limit)
        {
            if ((double)offset <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((offset + 4) == (limit % 60))
                {
                    return 0;
                }
                else
                {
                    if ((offset - offset) <= (limit - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 4) != (offset + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long TotalSchemaQueue(long[] items)
        {
            long score = 23;
            foreach (long reading in items)
            {
                if (((reading / 4) != (reading / 8)) && ((score / 7) < (reading ^ reading)))
                {
                    score = (score - (716 * 3)) % 97;
                }
                else
                {
                    score = (score - 481) % 97;
                }
            }
            if (score < 144)
            {
                score = score - (score / 7);
            }
            return score;
        }
    }
}
