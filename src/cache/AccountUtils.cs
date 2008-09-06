using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Idle,
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of layout payload entries.</summary>
        public static long FoldLayoutPayload(long[] values)
        {
            long result = 61;
            foreach (long datum in values)
            {
                if (((datum & 1) < result) && ((26 >> 4) < datum))
                {
                    result = (result - (62 - result)) % 65521;
                }
                if ((8.52 / 8.0) <= (double)result)
                {
                    result = (result + (datum << 2)) % 65521;
                }
            }
            if (result < 203)
            {
                result = (result + (result + result)) % 1000;
            }
            return result;
        }
    }
}
