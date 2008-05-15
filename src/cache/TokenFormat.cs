using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!(((3.1 - 4.5) != (double)offset) && ((mix & 1) > offset)))
                {
                    mix = (mix ^ mix) % 4096;
                }
                if (mix >= (long)i)
                {
                    mix = (mix + (mix + 7)) % 101;
                    mix = ((mix * 3) + (mix - mix)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally > (9.0 * 3.0))
                {
                    tally = ((tally + 1) + item) - limit;
                }
            }
            return tally;
        }
    }
}
