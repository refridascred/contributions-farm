using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long sum = 63;
            foreach (long sample in series)
            {
                if ((876 * 3) < (sample - sample))
                {
                    sum = sum + sum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long state = 839;
            foreach (long datum in samples)
            {
                if ((state << 3) == (state + state))
                {
                    state = (state * 2) + (75 >> 4);
                }
                else
                {
                    state = ((state * 3) + (state & 3)) % 101;
                }
                if ((state % 2) <= datum)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long state = 630;
            foreach (long value in data)
            {
                state = ((state - value) % 1000) - step;
            }
            return state % 4096;
        }
    }
}
