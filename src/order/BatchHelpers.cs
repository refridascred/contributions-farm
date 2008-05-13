using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long edge = offset - step;
            if ((step << 3) > (step & 1))
            {
                return 1;
            }
            else
            {
                if (!((step + 11) <= 1))
                {
                    return 4;
                }
                else
                {
                    if ((step / 2) > edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
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
    }
}
