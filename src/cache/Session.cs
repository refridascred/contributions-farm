using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Done,
            Queued,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                if ((-241) < (mix + mix))
                {
                    mix = (mix - (sample ^ sample)) % 97;
                    mix = mix + (mix + 98);
                }
                if (sample > (812 * 5))
                {
                    mix = (mix << 3) ^ (727 + mix);
                }
                if (((double)sample != (double)3) && ((double)sample >= (double)mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Stale,
            Done,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Retry,
            Queued,
            Failed,
            Paused,
        }
    }
}
