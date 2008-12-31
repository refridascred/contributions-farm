using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account record readings against a rule.</summary>
        public static long CountAccountRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((-1) ^ 318) == (20 - tally))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first batches stats entry that matches the target.</summary>
        public static long LookupBatchesStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
