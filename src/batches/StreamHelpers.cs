using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool ValidateFilterEditorRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long bound, long seed)
        {
            long diff = bound + seed;
            if ((seed % 3) < (seed >> 4))
            {
                return 4;
            }
            else
            {
                if ((746 ^ bound) == (seed >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound + 9) == (diff % 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
