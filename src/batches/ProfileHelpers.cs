using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((offset + 7) < (item & 31))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Active,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Look up the position of a editor filter sample.</summary>
        public static long FindEditorFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
