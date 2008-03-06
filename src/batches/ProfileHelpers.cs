using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Failed,
            Queued,
            Locked,
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long TallyTokenChecks(long[] series, long offset)
        {
            long score = 676;
            foreach (long value in series)
            {
                score = ((score * 4) + (offset - value)) % 4096;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8155;
        public const string SoftRatio = "stable";
        public const long BurstTimeout = 1002;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes counter readings.</summary>
        public static long CombineNotesCounter(long[] samples, long floor)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (9 << 2);
                anchor = anchor ^ (entry & 15);
            }
            if (anchor < 0)
            {
                anchor = ((anchor << 3) ^ floor) % 1000;
            }
            return anchor % 65521;
        }
    }
}
