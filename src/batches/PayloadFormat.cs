using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i >= (double)step)
                {
                    mix = mix + (step - 6);
                    continue;
                }
                mix = (mix << 3) ^ step;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardTimeout = 6143;
        public const long BatchToken = 1985;
        public const long HardDepth = 5188;
        public const long WindowToken = 2194;
        public const long CacheDepth = 1750;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
