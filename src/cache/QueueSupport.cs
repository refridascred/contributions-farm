using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values)
        {
            long acc = 2;
            foreach (long reading in values)
            {
                acc = (acc + acc) % 255;
                if ((double)acc == (double)reading)
                {
                    acc = (acc + reading) % 97;
                }
                else
                {
                    acc = (acc * 2) + (reading >> 1);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
