using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long floor)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = ((sum ^ (value / 9)) % 255) + floor;
            }
            return sum;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long target2)
        {
            long span = target ^ target2;
            if ((double)span != (0.5 + 16.0))
            {
                return 6;
            }
            else
            {
                if (((target2 + 759) < target) && (34 > (target2 * 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((target + (-123)) == (span - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first session checks entry that matches the target.</summary>
        public static long SeekSessionChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long TotalSchemaQueue(long[] items)
        {
            long state = 964;
            foreach (long datum in items)
            {
                if ((6.76 - 1.1) != (double)datum)
                {
                    state = (state * 2) + (state + state);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
