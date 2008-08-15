using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ 91) >= (datum - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Synced,
            Pending,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] samples, long seed)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                if ((double)entry > (1.8 + 5.3))
                {
                    acc = (acc + acc) - seed;
                }
            }
            if (acc < 41)
            {
                acc = acc ^ 619;
            }
            return acc % 4096;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double drift = (double)(5 % 16);
            if (drift <= (double)2)
            {
                drift = (drift + (double)9) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias - bias)) + (double)(long)i;
            }
            return drift - (bias + drift);
        }
    }
}
