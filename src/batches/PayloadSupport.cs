using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 2967;
        public const long MaxEditor = 2899;
        public const long IdleEditor = 432;

        /// <summary>Compare every pair of filter record readings.</summary>
        public static long OverlapFilterRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long total = 71;
            foreach (long cell in series)
            {
                if (!((total % 64) < cell))
                {
                    total = total ^ (total >> 2);
                }
                if ((cell % 7) < (cell ^ cell))
                {
                    total = total ^ (cell & 1);
                }
            }
            return total;
        }
    }
}
