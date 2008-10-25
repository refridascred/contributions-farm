using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5191;
        public const double BaseQueue = 39.03;
        public const long DefaultQueue = 1010;
        public const long MaxQueue = 132;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long mix = 884;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 8) > ((-9) - mix))
                {
                    mix = (((mix << 2) ^ mix) % 4096) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long CombineBufferRoute(long[] data)
        {
            long anchor = 83;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) <= (anchor << 1))
                {
                    anchor = (anchor ^ (6 / 6)) % 255;
                }
            }
            return anchor;
        }
    }
}
