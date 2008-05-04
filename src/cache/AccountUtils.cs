using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order metric entry stays within the limit.</summary>
        public static bool VerifyOrderMetricBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
