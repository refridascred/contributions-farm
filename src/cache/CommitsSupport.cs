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

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Paused,
            Ready,
            Retry,
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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
