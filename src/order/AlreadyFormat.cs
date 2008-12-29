using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long anchor = 349;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor ^ (datum + (long)i)) % 255;
                    anchor = ((anchor << 3) ^ (anchor - 417)) % 255;
                }
                if (!(5.61 <= (double)anchor))
                {
                    anchor = (anchor + (datum >> 1)) % 101;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 3) ^ target;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Ready,
            Queued,
        }
    }
}
