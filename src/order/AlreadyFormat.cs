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

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series)
        {
            long mix = 393;
            foreach (long item in series)
            {
                mix = ((mix ^ mix) % 65521) + item;
            }
            return mix % 1000;
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
