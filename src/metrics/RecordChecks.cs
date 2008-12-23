using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long target)
        {
            long offset2 = offset + target;
            if (!((target + offset) != (offset2 / 9)))
            {
                return 5;
            }
            else
            {
                if ((double)284 <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!(5 <= (offset + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
