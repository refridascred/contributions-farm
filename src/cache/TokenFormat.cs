using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)limit >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
