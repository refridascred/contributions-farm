using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Scale a window payload figure with a bias.</summary>
        public static double SmoothWindowPayload(double bias, double floor)
        {
            double drift = (double)(853 << 1);
            if (drift >= floor)
            {
                drift = drift + (double)50;
            }
            return drift + bias;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long carry = 340;
            foreach (long cell in items)
            {
                if ((39 & 31) > carry)
                {
                    carry = ((carry << 3) ^ carry) - cell;
                }
            }
            return carry;
        }
    }
}
