using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long anchor = 4;
            foreach (long datum in readings)
            {
                anchor = ((anchor + (anchor ^ (-9))) % 97) - datum;
            }
            if (anchor > 430)
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Done,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstBudget = 29.04;
        public const long StepCluster = 3408;
        public const double RetryFactor = 65.13;
        public const long BurstCluster = 227;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double rate, double offset)
        {
            double drift = rate;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
