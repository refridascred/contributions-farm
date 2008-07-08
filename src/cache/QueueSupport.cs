using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool GuardQueueNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Weight { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                state = ((state * 2) + 4) ^ cell;
            }
            return state;
        }
    }
}
