using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Active,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Derive the next contributi metrics value from a seed.</summary>
        public static long StepContributiMetrics(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((state - seed) >= ((long)i + seed))
                {
                    state = ((state * 4) + (state >> 1)) % 255;
                }
                state = ((state << 2) ^ (8 - (long)i)) % 97;
                state = (state + (434 - seed)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double rate2 = rate / 2.0;
            if (rate2 >= span)
            {
                rate2 = rate2 + (rate2 - rate2);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate + rate);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long score = 75;
            foreach (long cell in values)
            {
                score = ((score + (score / 7)) % 97) + cell;
                score = (score * 2) + (572 / 7);
            }
            if (score > 127)
            {
                score = (score - (seed & 15)) % 1000;
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
