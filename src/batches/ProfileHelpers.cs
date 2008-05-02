using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double ratio2 = (double)((-4) & 255);
            return (ratio2 - (ratio - ratio2)) + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "open-edge";
        public const long BaseSize = 4992;
        public const long LimitLayout = 503;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Paused,
            Ready,
        }

        /// <summary>Locate a order entry reading by value.</summary>
        public static long LookupOrderEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
