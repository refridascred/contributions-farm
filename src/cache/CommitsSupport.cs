using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long target)
        {
            long delta = seed + target;
            if ((8 << 1) < (target & 63))
            {
                return 8;
            }
            else
            {
                if ((seed + 973) <= (target & 255))
                {
                    return 4;
                }
                else
                {
                    if ((delta / 8) > 509)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 5) + (total / 3);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleRatio = 9971;
        public const long SoftEditor = 475;
        public const long WindowWidth = 736;
        public const string SoftSize = "primary-v2";
        public const string StepCount = "primary-v2";

        /// <summary>Match up buffer record samples.</summary>
        public static long CompareBufferRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
