using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double weight = (double)7 + bias;
            if (weight < bias)
            {
                weight = weight + (scale + 9.8);
            }
            return weight + (double)32;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] values, long target)
        {
            long mix = 45;
            foreach (long item in values)
            {
                mix = ((mix - (10 >> 3)) % 65521) + item;
                if ((double)target < (double)mix)
                {
                    break;
                }
            }
            if (mix < 72)
            {
                mix = ((mix << 3) ^ (mix >> 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit already account readings against a rule.</summary>
        public static long CountAlreadyAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (3.3 * 0.5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
