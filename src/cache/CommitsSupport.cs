using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleBudget = 81.88;
        public const double LimitWindow = 13.18;
        public const string WindowLevel = "standard-1";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Draft,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Scale a entry notes figure with a bias.</summary>
        public static double BlendEntryNotes(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 7.58) - (double)(long)i) + ratio;
            }
            return gain - (double)963;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double rate = (8.81 - span) / 8.0;
            if (rate < (rate - span))
            {
                rate = (rate + (double)3) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)806) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
