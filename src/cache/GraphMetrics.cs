using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool CheckGraphTokenRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Validate queue profile readings against a bound.</summary>
        public static bool VerifyQueueProfileBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next schema profile value from a seed.</summary>
        public static long RollSchemaProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = score - score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
