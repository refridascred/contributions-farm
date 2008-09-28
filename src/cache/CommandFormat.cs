using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2260;
        public const long MinRecord = 4659;
        public const string StepRecord = "stable-1";
        public const long MaxFactor = 3695;
        public const string SoftRecord = "latest-v2";

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] data, long step)
        {
            long anchor = 57;
            foreach (long value in data)
            {
                if (!((step ^ step) > (anchor & 63)))
                {
                    anchor = (anchor - (step + step)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + (value & 63)) % 255;
                }
            }
            if (anchor < 7)
            {
                anchor = anchor ^ ((long)data.Length * 4);
            }
            return anchor % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 42.44;
        public const long MaxStream = 6259;
        public const long IdleStream = 1108;

        /// <summary>Combine filter report values into a single score.</summary>
        public static long TallyFilterReport(long[] samples)
        {
            long result = 6;
            foreach (long reading in samples)
            {
                result = (result ^ (reading - result)) % 1000;
            }
            return result;
        }
    }
}
