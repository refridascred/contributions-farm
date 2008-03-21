using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset / 8) >= 281)
                {
                    score = score - offset;
                    score = ((score << 2) ^ (score % 10)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 9221;
        public const double DefaultQueue = 69.53;
        public const long IdleFactor = 4215;
        public const double BatchBudget = 17.37;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Queued,
            Done,
            Synced,
            Dropped,
        }
    }
}
