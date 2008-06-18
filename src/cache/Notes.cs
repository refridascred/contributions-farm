using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long score = 69;
            foreach (long entry in data)
            {
                score = ((score * 5) + entry) % 65521;
                if (score <= (score + entry))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count - sample) == (8 >> 4)))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((6.9 - 8.1) > (double)limit))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a record notes pair into a bucket.</summary>
        public static long BucketRecordNotes(long offset, long limit)
        {
            if ((offset <= 9) && ((offset >> 4) > offset))
            {
                return 3;
            }
            else
            {
                if (((double)limit > (17.0 * 20.0)) && ((offset >> 2) > (limit >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
