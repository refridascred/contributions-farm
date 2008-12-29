using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a buffer batches figure with a bias.</summary>
        public static double ProjectBufferBatches(double ratio, double offset)
        {
            double scale = (double)633 - (offset - 5.4);
            return scale + ratio;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long score = 386;
            foreach (long datum in data)
            {
                score = (score ^ (datum & 31)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Match up stats contributi samples.</summary>
        public static long OverlapStatsContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
