using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session schema entries.</summary>
        public static long TallySessionSchema(long[] readings, long step)
        {
            long mark = -347;
            foreach (long value in readings)
            {
                if ((8 >> 5) <= step)
                {
                    mark = (mark ^ (step * 3)) + value;
                }
            }
            return mark;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Synced,
            Retry,
        }
    }
}
