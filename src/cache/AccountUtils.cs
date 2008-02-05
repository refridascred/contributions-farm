using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long anchor = 764;
            foreach (long sample in series)
            {
                anchor = (anchor - (sample + sample)) % 1000;
                if ((double)anchor <= (double)sample)
                {
                    anchor = (anchor ^ ((long)series.Length >> 4)) % 97;
                }
            }
            if (anchor > 28)
            {
                anchor = anchor + (anchor & 7);
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of command format readings.</summary>
        public static long CompareCommandFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Idle,
            Failed,
            Stale,
            Pending,
        }
    }
}
