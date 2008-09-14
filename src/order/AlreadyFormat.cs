using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(hits > value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit record payload readings against a rule.</summary>
        public static long TallyRecordPayloadOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length < (cell + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = (mix - (mix & 1)) - cell;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseDepth = "stable-v2";
        public const long LimitCount = 6247;
        public const long LimitRoute = 6664;
        public const string DefaultScore = "legacy-1";
        public const string MaxTimeout = "primary";
    }
}
