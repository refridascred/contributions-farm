using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Synced,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
