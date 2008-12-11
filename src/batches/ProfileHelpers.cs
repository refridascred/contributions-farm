using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long offset)
        {
            long state = 36;
            foreach (long cell in levels)
            {
                if ((state + cell) >= (state + state))
                {
                    state = (state + offset) % 101;
                }
                else
                {
                    state = (state ^ offset) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((-96) <= (matches >> 4)))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - (long)data.Length) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 897;
        public const long DefaultBudget = 3946;
        public const long LimitBatches = 1220;
    }
}
