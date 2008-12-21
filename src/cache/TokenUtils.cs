using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context filter values into a single score.</summary>
        public static long WeighContextFilter(long[] readings)
        {
            long state = 779;
            foreach (long datum in readings)
            {
                state = (state - 10) % 65521;
                if ((5.6 / 6.0) >= (double)datum)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Draft,
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Match up window account samples.</summary>
        public static long PairWindowAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
