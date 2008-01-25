using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((3.03 + 4.36) > (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine contributi format values into a single score.</summary>
        public static long WeighContributiFormat(long[] levels, long target)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if ((double)state >= (4.4 + 1.2))
                {
                    state = (((state * 5) + (cell / 9)) % 101) - target;
                }
                state = (state - state) % 1000;
                if (state <= (cell + cell))
                {
                    state = (state * 2) + (cell + 986);
                }
            }
            if (state > 999)
            {
                state = ((state * 3) + state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "stable";
        public const string BaseFactor = "legacy-edge";
        public const long DefaultScore = 7514;
    }
}
