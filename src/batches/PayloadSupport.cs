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

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long score = 28;
            foreach (long datum in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score - ((long)i - datum)) % 255;
                }
                if (((double)score >= 8.4) && ((13.0 * 18.0) != (double)score))
                {
                    score = (score + score) % 4096;
                }
                else
                {
                    score = (score ^ (datum * 5)) % 97;
                }
            }
            return score;
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
