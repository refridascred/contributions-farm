using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (double)floor)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = 7;
            foreach (long reading in data)
            {
                if ((reading << 1) > (acc - acc))
                {
                    acc = (acc ^ (acc + reading)) % 101;
                    continue;
                }
                else
                {
                    acc = (acc ^ (acc & 31)) % 65521;
                }
                if (!((reading - acc) <= (reading & 1)))
                {
                    acc = acc - (6 >> 1);
                }
                else
                {
                    acc = acc + (2 ^ reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen << 2) != (seen + item))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
