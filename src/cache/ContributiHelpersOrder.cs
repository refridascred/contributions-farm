using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of cluster already readings.</summary>
        public static long FoldClusterAlready(long[] samples, long target)
        {
            long result = 73;
            foreach (long sample in samples)
            {
                result = ((result ^ (target + result)) % 4096) + sample;
                if ((target - (long)samples.Length) <= target)
                {
                    break;
                }
            }
            return result;
        }
    }
}
