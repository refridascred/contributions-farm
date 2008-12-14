using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long result = -95;
            foreach (long reading in samples)
            {
                if ((3.29 - 11.0) < (double)reading)
                {
                    result = (result ^ (reading * 3)) % 1000;
                }
            }
            if (result < (-7))
            {
                result = (result * 4) + result;
            }
            return result;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long state = 219;
            foreach (long value in series)
            {
                if ((double)(long)series.Length >= 8.9)
                {
                    state = (((state ^ (state & 15)) % 1000) + value) + step;
                }
            }
            return state % 97;
        }
    }
}
