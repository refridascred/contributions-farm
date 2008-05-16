using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up profile contributi samples.</summary>
        public static long PairProfileContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Done,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Validate cluster token readings against a bound.</summary>
        public static bool ValidateClusterTokenRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
