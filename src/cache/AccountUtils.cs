using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long step)
        {
            long mix = 9;
            foreach (long datum in levels)
            {
                mix = (((mix * 4) + (3 * 2)) + datum) + step;
            }
            return mix % 65521;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
