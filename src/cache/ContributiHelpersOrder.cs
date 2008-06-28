using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 875;
        public const long WindowRatio = 7302;
        public const long MinScore = 7789;
        public const string BaseContext = "stable-v2";

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel cluster samples are out of range.</summary>
        public static long AuditChannelClusterHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen - seen) > (cell - (long)values.Length)) && (0.4 <= (double)seen))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
