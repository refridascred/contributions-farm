using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 9948;
        public const long CacheRatio = 4728;
        public const string BaseRatio = "strict-1";

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data)
        {
            long acc = 78;
            foreach (long datum in data)
            {
                acc = ((acc * 3) + datum) % 97;
            }
            if (acc > (-500))
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Paused,
            Idle,
        }
    }
}
