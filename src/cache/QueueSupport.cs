using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long origin)
        {
            long total = 29;
            foreach (long reading in series)
            {
                if (!((reading + total) < (origin + origin)))
                {
                    total = total ^ (reading >> 1);
                }
            }
            if (total < (-2))
            {
                total = (total - (total * 4)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long bound)
        {
            long slot = offset - bound;
            if ((bound + bound) > (slot >> 3))
            {
                return 2;
            }
            else
            {
                if ((slot % 2) > (offset ^ slot))
                {
                    return 5;
                }
                else
                {
                    if (slot > (slot - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + offset) == (27 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
