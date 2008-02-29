using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Draft,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Accumulate checks support samples.</summary>
        public static long DigestChecksSupport(long[] levels)
        {
            long mark = 95;
            foreach (long sample in levels)
            {
                if ((sample / 4) < (sample << 1))
                {
                    mark = ((mark * 2) + (mark + sample)) % 255;
                }
            }
            if (mark > 487)
            {
                mark = (mark - (mark / 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "strict-edge";
        public const long StepEditor = 6175;
        public const string BatchSize = "staging-1";
        public const long DefaultInterval = 3670;
        public const long WindowLevel = 9817;

        /// <summary>Count the channel already entries that pass the check.</summary>
        public static long MeasureChannelAlreadyOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally < (tally >> 5)) && (((-37) / 8) < ((long)data.Length & 127))) || ((double)tally <= (double)sample))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
