using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long sum = 914;
            foreach (long sample in readings)
            {
                if ((sum % 12) > 78)
                {
                    sum = (sum + (sample - 81)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
