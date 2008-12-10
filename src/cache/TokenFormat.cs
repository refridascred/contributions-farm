using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + 5) == (reading + tally))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer schema values into a single score.</summary>
        public static long TallyBufferSchema(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                acc = (acc ^ (sample / 2)) % 65521;
                if (((sample * 5) <= (sample & 7)) || ((60 - acc) < (962 + sample)))
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long floor)
        {
            long span = bound - floor;
            if ((9.2 - 18.0) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((2.1 - 20.0) >= (double)span)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
