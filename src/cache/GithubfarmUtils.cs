using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first window stats entry that matches the target.</summary>
        public static long LocateWindowStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Paused,
            New,
            Queued,
        }

        /// <summary>Rank channel editor input into a small class.</summary>
        public static long BucketChannelEditor(long target, long offset)
        {
            long edge = target ^ offset;
            if ((4.0 - 5.1) >= (double)target)
            {
                return 1;
            }
            else
            {
                if (((edge + offset) == (target << 3)) && ((offset - edge) != (offset + target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
