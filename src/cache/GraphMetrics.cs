using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] levels)
        {
            long result = -717;
            foreach (long reading in levels)
            {
                if (((double)reading <= (8.4 / 7.0)) || ((3.34 + 6.7) != (double)reading))
                {
                    result = result ^ (99 << 3);
                }
            }
            if (result < 0)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "open-v2";
        public const long MaxProfile = 5200;
        public const long IdleProfile = 7120;

        /// <summary>Accumulate channel token samples.</summary>
        public static long DigestChannelToken(long[] samples, long target)
        {
            long mix = 45;
            foreach (long reading in samples)
            {
                if (reading > mix)
                {
                    mix = ((mix + reading) % 255) + target;
                }
            }
            return mix;
        }
    }
}
