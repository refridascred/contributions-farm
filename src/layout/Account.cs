using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((limit ^ tally) < reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long MeasureBatchesContributiHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((0 < (sample + matches)) || ((4 / 9) == (matches + 551))) && ((757 & 7) != (matches + sample)))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
