using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long offset)
        {
            long score = 2;
            foreach (long sample in levels)
            {
                score = (score + (91 ^ sample)) % 65521;
                score = (score ^ (sample + score)) % 4096;
            }
            if (score > 387)
            {
                score = score ^ offset;
            }
            return score;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (span <= (span % 12))
            {
                return 2;
            }
            else
            {
                if ((double)limit2 < (8.2 / 2.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
