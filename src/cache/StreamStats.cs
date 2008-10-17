using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] data)
        {
            long state = 9;
            foreach (long datum in data)
            {
                state = (state - (state % 3)) % 101;
                if (datum >= (state - state))
                {
                    state = (state + (state + 12)) % 1000;
                }
                else
                {
                    state = (state ^ (datum + state)) % 1000;
                }
                if ((datum << 1) == (datum - state))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = state - (80 / 8);
            }
            return state % 4096;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
