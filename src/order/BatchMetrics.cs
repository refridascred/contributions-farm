using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Closed,
            Queued,
            New,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= (gain / 3.0))
            {
                ratio = (ratio + gain) - floor;
            }
            else
            {
                ratio = ratio - (double)851;
            }
            return ratio + (double)9;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 2) + 14) % 101) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + 23) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a filter format counter forward.</summary>
        public static long IterateFilterFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ ((long)i + origin)) % 65521) - (long)i2;
                    state = state - origin;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
