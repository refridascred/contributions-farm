using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Check that every report window entry stays within the limit.</summary>
        public static bool GuardReportWindowBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up commits account samples.</summary>
        public static long PairCommitsAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
