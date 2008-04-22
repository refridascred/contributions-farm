using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a filter layout pair into a bucket.</summary>
        public static long BucketFilterLayout(long offset, long step)
        {
            if ((76 > (offset % 10)) && ((double)offset != (5.6 * 9.1)))
            {
                return 6;
            }
            else
            {
                if (!(offset < (offset - offset)))
                {
                    return 0;
                }
                else
                {
                    if (!((step % 5) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(26 < (step / 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format cluster samples.</summary>
        public static long MatchFormatClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
