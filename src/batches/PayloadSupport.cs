using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many report cluster samples are out of range.</summary>
        public static long AuditReportClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2 * 2) >= (count + count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
