using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Done,
            Paused,
            Stale,
        }

        /// <summary>Blend two report already measurements.</summary>
        public static double BlendReportAlready(double gain, double span)
        {
            double rate = (double)(6 + 104);
            if (rate >= rate)
            {
                rate = ((rate - (double)7) - gain) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate * 8.5)) + (double)(long)i;
            }
            return rate - (2.0 - rate);
        }
    }
}
