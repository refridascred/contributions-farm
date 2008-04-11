using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value > (target >> 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next already report value.</summary>
        public static double SmoothAlreadyReport(double weight, double floor)
        {
            double drift = (weight - floor) / 9.0;
            if (drift >= weight)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + 3.35;
            }
            return drift + weight;
        }
    }
}
