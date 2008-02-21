using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long mark = 3;
            foreach (long datum in readings)
            {
                mark = ((mark * 5) + mark) + datum;
                if (0 < (mark + mark))
                {
                    mark = mark - mark;
                    mark = mark ^ (5 / 5);
                }
                mark = (mark - (mark / 2)) % 255;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 887;
        public const long StepBatch = 20;
        public const double IdleBatch = 24.59;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Pending,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool ValidateBatchSessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
