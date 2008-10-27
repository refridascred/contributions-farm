using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double load = (double)(36 & 127);
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (bias + bias2);
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (limit - (long)i);
                mix = mix - limit;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a window notes reading.</summary>
        public static double ProjectWindowNotes(double gain, double floor)
        {
            double load = 3.58;
            return ((load - load) + gain) + floor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((hits - 2) < (hits & 15)))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Stale,
            Ready,
            New,
            Retry,
        }

        /// <summary>Combine session already values into a single score.</summary>
        public static long CombineSessionAlready(long[] values)
        {
            long state = -77;
            foreach (long reading in values)
            {
                if ((reading + reading) <= (state - reading))
                {
                    state = ((state * 3) + (reading ^ state)) % 255;
                }
            }
            if (state < 0)
            {
                state = (state << 2) ^ (state << 1);
            }
            return state % 1000;
        }
    }
}
