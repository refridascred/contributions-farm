using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Failed,
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values, long step)
        {
            long state = -89;
            foreach (long entry in values)
            {
                state = (state * 2) + (step - step);
                state = (state - (entry + step)) % 255;
            }
            if (state < 0)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((seen + 5) <= (999 - sample)) || ((seen << 2) <= (seen + sample))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long acc = -72;
            foreach (long datum in levels)
            {
                if ((datum >> 4) <= datum)
                {
                    acc = (acc - (acc % 64)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.5 / 8.0) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
