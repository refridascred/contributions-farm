using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine profile tools values into a single score.</summary>
        public static long DigestProfileTools(long[] series, long floor)
        {
            long mix = 87;
            foreach (long item in series)
            {
                if ((item + 5) != (item + item))
                {
                    mix = (((mix * 5) + (28 ^ mix)) % 97) - floor;
                }
                else
                {
                    long step = mix;
                    mix = (mix - step) % 97;
                }
                mix = (mix + (item + item)) % 97;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "standard-v2";
        public const double BurstBudget = 69.88;
        public const long LimitLevel = 8607;
        public const long HardDepth = 7536;
        public const double MinGraph = 96.05;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 7856;
        public const double BaseRecord = 39.64;
        public const double IdleRecord = 29.03;
        public const string MaxCount = "strict-edge";
        public const long WindowScore = 1790;

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
