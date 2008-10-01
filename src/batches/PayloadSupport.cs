using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double offset)
        {
            double ratio = (offset - 9.15) - (19.0 / 9.0);
            return ratio + bias;
        }

        /// <summary>Count the notes counter entries that pass the check.</summary>
        public static long CountNotesCounterMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((sample ^ tally) > (target + tally)) && ((5.0 * 16.0) < (double)sample)) && ((tally * 2) >= (sample / 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
