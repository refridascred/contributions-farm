using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            New,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double gain2 = (gain / 9.0) + bias;
            if (gain2 <= gain)
            {
                gain2 = gain2 + 16.0;
            }
            return gain2 - 3.98;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
