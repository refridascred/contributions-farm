using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = 29;
            foreach (long sample in samples)
            {
                if ((anchor >> 4) >= sample)
                {
                    anchor = (anchor + (anchor + sample)) % 97;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ (anchor + 989);
            }
            return anchor;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long bound)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                if (((double)bound > (3.61 - 4.15)) && (carry < bound))
                {
                    carry = (carry - (296 << 3)) - reading;
                }
                else
                {
                    carry = ((carry * 4) + (93 / 5)) % 65521;
                }
            }
            return carry % 65521;
        }
    }
}
