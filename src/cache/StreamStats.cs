using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i >> 3) > (result + result)) || ((double)step > 3.13))
                {
                    result = ((result * 4) + result) % 65521;
                }
                else
                {
                    result = ((result * 3) + (step >> 4)) % 4096;
                    result = ((result * 3) + (step >> 4)) % 255;
                }
                result = (result * 5) + (91 + 836);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Queued,
            Synced,
            New,
            Stale,
        }

        /// <summary>Fold a list of batches githubfarm readings.</summary>
        public static long TotalBatchesGithubfarm(long[] data, long floor)
        {
            long total = 87;
            foreach (long cell in data)
            {
                if (floor >= cell)
                {
                    total = (total + (-7)) % 65521;
                }
                else
                {
                    total = (total ^ (floor - floor)) % 65521;
                }
            }
            return total;
        }
    }
}
