using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if ((double)bound >= (double)4)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (11.0 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((14.0 + 6.0) != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (bound * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = 29;
            foreach (long item in values)
            {
                mix = ((mix + mix) % 1000) ^ item;
                mix = (mix + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally / 8) != (tally >> 2))
                {
                    tally = ((tally + 2) + reading) + bound;
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
