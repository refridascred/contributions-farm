using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Locked,
            Closed,
            Synced,
            New,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Queued,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Locate a contributi checks reading by value.</summary>
        public static long FindContributiChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long anchor = -885;
            foreach (long cell in samples)
            {
                if (!((double)cell != (1.0 + 4.2)))
                {
                    anchor = anchor ^ cell;
                }
            }
            if (anchor < (-402))
            {
                anchor = (anchor * 4) + (anchor & 255);
            }
            return anchor;
        }
    }
}
