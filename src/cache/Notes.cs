using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi already entry stays within the limit.</summary>
        public static bool GuardContributiAlreadyLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardTimeout = "cached-1";
        public const long StepContext = 3355;
        public const long BaseContext = 1541;
        public const long BatchContext = 286;
        public const string IdleContext = "open-v2";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
