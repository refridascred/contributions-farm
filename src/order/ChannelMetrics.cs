using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a account graph counter forward.</summary>
        public static long StepAccountGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (8 - (long)i)) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series, long seed)
        {
            long sum = 0;
            foreach (long item in series)
            {
                if ((seed >> 3) < sum)
                {
                    sum = (sum ^ (540 + seed)) + item;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((double)entry == (7.24 * 10.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
