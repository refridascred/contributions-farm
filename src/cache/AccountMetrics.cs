using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Paused,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] data, long step)
        {
            long result = 428;
            foreach (long datum in data)
            {
                result = ((result + (step + result)) % 97) - datum;
            }
            return result % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 3042;
        public const long StepLevel = 1146;
        public const long HardCommand = 9911;
        public const long LimitRatio = 373;

        /// <summary>Fold a list of counter metrics readings.</summary>
        public static long FoldCounterMetrics(long[] values)
        {
            long state = -8;
            foreach (long cell in values)
            {
                if ((9.91 / 6.0) >= (double)state)
                {
                    state = ((state * 2) + (cell ^ 152)) % 255;
                    state = (state ^ (531 >> 2)) % 101;
                }
                if ((state & 31) < (cell * 5))
                {
                    state = ((state * 4) + (cell + cell)) % 97;
                }
                if ((cell & 7) == (cell ^ state))
                {
                    state = (state << 2) ^ (state >> 3);
                }
            }
            if (state < 6)
            {
                state = (state << 3) ^ (state + state);
            }
            return state;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Ready,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
