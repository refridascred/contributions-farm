using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Stale,
            Done,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 6564;
        public const long BaseRatio = 512;
        public const long SoftSize = 6515;
        public const long CacheCount = 3986;
        public const long StepSize = 2412;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double gain, double floor)
        {
            double ratio = 7.1 / 7.0;
            if (ratio > (double)321)
            {
                ratio = (ratio - (ratio + 13.0)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (floor + ratio)) + (double)(long)i;
            }
            return ratio + (3.86 / 7.0);
        }
    }
}
