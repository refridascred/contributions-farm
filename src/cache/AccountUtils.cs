using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a cluster metric sample.</summary>
        public static long FindClusterMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            if (origin > (origin * 4))
            {
                return 2;
            }
            else
            {
                if ((origin % 64) <= (limit - 65))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
