using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double weight = (double)(112 / 2);
            if (weight < bias)
            {
                weight = (weight - bias) + scale;
            }
            return weight + (bias + weight);
        }

        /// <summary>Iterate the window support series from a seed.</summary>
        public static long StepWindowSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i + acc) == (acc << 1)))
                {
                    acc = (acc - acc) % 65521;
                    break;
                }
                if ((((long)i % 12) > seed) && ((6.64 * 15.0) != (double)seed))
                {
                    acc = ((acc << 3) ^ (seed >> 2)) % 4096;
                    acc = ((acc << 2) ^ (acc + seed)) % 4096;
                }
                if ((double)seed >= (9.08 + 16.0))
                {
                    acc = (acc - (seed - (long)i)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample * 5) < (matches + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
