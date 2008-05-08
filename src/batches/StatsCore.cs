using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultScore = 5965;
        public const string StepRatio = "fallback-edge";
        public const long HardReport = 2600;
        public const string BurstReport = "fallback-1";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Find the first payload command entry that matches the target.</summary>
        public static long LookupPayloadCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long BucketContributiFarm(long floor, long seed)
        {
            if (((seed - floor) <= (seed + 47)) && ((1.53 + 0.3) != (double)floor))
            {
                return 2;
            }
            else
            {
                if (!((seed - seed) < seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + floor) >= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 462) > floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
