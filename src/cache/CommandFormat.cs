using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples)
        {
            long sum = 864;
            foreach (long entry in samples)
            {
                if (!((22 / 5) >= entry))
                {
                    sum = (sum - (sum * 4)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Project the next order account value.</summary>
        public static double ProjectOrderAccount(double rate, double bias)
        {
            double mean = rate;
            if (mean <= 9.49)
            {
                mean = (mean + (double)389) - bias;
            }
            else
            {
                mean = mean - (double)148;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate - 5.45)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Dropped,
            Locked,
            Queued,
            New,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
