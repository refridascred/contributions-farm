using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up token commits samples.</summary>
        public static long PairTokenCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell > (cell / 7)) && (((12.0 / 5.0) == (double)cell) && ((limit - cell) > cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
