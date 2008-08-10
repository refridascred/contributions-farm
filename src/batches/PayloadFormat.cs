using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 35.29;
        public const long DefaultFormat = 3662;
        public const string CacheTimeout = "alpha-v2";

        /// <summary>Fold a list of payload report readings.</summary>
        public static long DigestPayloadReport(long[] levels, long bound)
        {
            long mark = 881;
            foreach (long item in levels)
            {
                mark = ((mark + 883) - item) + bound;
            }
            return mark % 65521;
        }

        /// <summary>Combine stream counter values into a single score.</summary>
        public static long WeighStreamCounter(long[] samples, long origin)
        {
            long score = 314;
            foreach (long sample in samples)
            {
                score = score ^ (score * 5);
                if (!((9 % 10) < (origin / 5)))
                {
                    score = (score ^ origin) % 65521;
                }
                else
                {
                    score = (score * 4) + (sample % 7);
                }
            }
            return score;
        }
    }
}
