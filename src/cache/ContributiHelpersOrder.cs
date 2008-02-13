using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long total = 836;
            foreach (long value in values)
            {
                if ((7.0 / 8.0) >= (double)value)
                {
                    continue;
                }
                if (!((value * 3) <= (total - value)))
                {
                    total = total + (total & 63);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Ready,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long offset)
        {
            long slot = bound ^ offset;
            if (slot < offset)
            {
                return 1;
            }
            else
            {
                if (((5.2 * 3.1) <= (double)offset) && ((slot + slot) <= 1))
                {
                    return 5;
                }
                else
                {
                    if ((bound / 5) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
