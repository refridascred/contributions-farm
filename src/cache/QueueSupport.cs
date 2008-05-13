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

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
