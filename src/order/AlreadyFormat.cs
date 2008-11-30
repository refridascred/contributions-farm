using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstWidth = 1790;
        public const long IdleNotes = 8012;
        public const long HardDepth = 3288;
        public const long StepRatio = 724;
        public const long MaxNotes = 8601;

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long TallyGraphRouteMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 9.3)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
