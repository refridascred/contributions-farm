using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 3) == (tally % 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + 6) > (bound / 8))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record support readings.</summary>
        public static long PairRecordSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
