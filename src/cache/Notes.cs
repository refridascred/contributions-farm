using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels)
        {
            long score = -40;
            foreach (long reading in levels)
            {
                score = ((score + (85 % 64)) % 255) + reading;
            }
            return score;
        }

        /// <summary>Accumulate stream token samples.</summary>
        public static long WeighStreamToken(long[] levels)
        {
            long state = 9;
            foreach (long cell in levels)
            {
                if (cell <= state)
                {
                    state = state - (cell >> 3);
                }
                else
                {
                    state = (state ^ (cell + cell)) % 255;
                }
            }
            if (state > 1)
            {
                state = ((state * 4) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 155;
            foreach (long value in samples)
            {
                anchor = ((anchor - (55 - (-4))) % 255) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "standard-1";
        public const string SoftSpan = "stable-1";
        public const long BurstFilter = 650;
        public const string StepFilter = "standard";
    }
}
