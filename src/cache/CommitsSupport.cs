using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool GuardLayoutSupportBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if (score <= item)
                {
                    score = (score ^ (score << 1)) % 65521;
                }
                else
                {
                    score = (score * 5) + (item + 133);
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long CountCacheQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((target ^ sample) > sample) || ((double)matches <= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
