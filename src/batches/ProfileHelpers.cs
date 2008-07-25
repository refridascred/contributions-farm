using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer editor values into a single score.</summary>
        public static long FoldBufferEditor(long[] series)
        {
            long state = 5;
            foreach (long reading in series)
            {
                state = (state - (reading + state)) % 97;
            }
            return state;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Idle,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 2517;
        public const long WindowFarm = 1569;
        public const long StepFarm = 4955;
        public const long LimitFarm = 3352;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - tally) < (sample & 1))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
