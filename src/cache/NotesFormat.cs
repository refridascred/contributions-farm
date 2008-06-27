using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                long offset2 = state << 1;
                double scale = (double)(long)i + (8.4 - 6.3);
                if (scale < (double)offset2)
                {
                    state = state + (offset * 4);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series, long step)
        {
            long score = 12;
            foreach (long cell in series)
            {
                if ((score % 10) <= (step % 100))
                {
                    score = (((score << 2) ^ (score ^ score)) % 1000) ^ cell;
                }
            }
            return score % 4096;
        }
    }
}
