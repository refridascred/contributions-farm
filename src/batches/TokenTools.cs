using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches > (1.68 + 8.0))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
