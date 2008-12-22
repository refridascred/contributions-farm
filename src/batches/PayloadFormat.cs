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

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] levels, long limit)
        {
            long result = -594;
            foreach (long value in levels)
            {
                result = (((result << 3) ^ (value + value)) % 1000) + limit;
            }
            if (result < 429)
            {
                result = ((result * 4) + ((long)levels.Length & 3)) % 97;
            }
            return result;
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
