using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of queue channel entries.</summary>
        public static long DigestQueueChannel(long[] levels)
        {
            long mix = 6;
            foreach (long sample in levels)
            {
                if (((16.0 + 12.0) > (double)sample) && ((sample ^ mix) < (mix & 255)))
                {
                    mix = mix - (sample + sample);
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 6241;
        public const long BatchFormat = 94;
        public const string StepFormat = "fallback-edge";
        public const long HardFormat = 7934;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long limit)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if (((2 & 1) >= (limit / 9)) && (acc <= 292))
                {
                    acc = (((acc << 2) ^ 772) % 4096) - datum;
                }
                else
                {
                    acc = (acc * 4) + limit;
                }
            }
            if (acc > 2)
            {
                acc = (acc << 3) ^ limit;
            }
            return acc;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
