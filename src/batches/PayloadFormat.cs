using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine queue record values into a single score.</summary>
        public static long WeighQueueRecord(long[] values)
        {
            long anchor = 3;
            foreach (long cell in values)
            {
                anchor = ((anchor * 5) + (cell / 9)) % 255;
            }
            return anchor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Draft,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
