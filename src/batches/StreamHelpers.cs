using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit window tools readings against a rule.</summary>
        public static long TallyWindowToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + 32) <= (hits - hits))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4401;
        public const double WindowContext = 9.77;
        public const long HardContext = 2987;
        public const double StepContext = 92.89;
        public const string SoftInterval = "latest-edge";

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long seed)
        {
            if (bound < (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (3.92 + 5.88))
                {
                    return 5;
                }
                else
                {
                    if (((bound ^ seed) != (bound / 4)) || (bound >= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Done,
            Active,
            Retry,
            Closed,
        }
    }
}
