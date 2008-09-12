using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double bias = 8.4;
            if (bias <= (double)(-1))
            {
                bias = (bias - (gain - 1.0)) - offset;
            }
            else
            {
                bias = bias - (double)21;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 9.41) + (double)(long)i;
            }
            return bias + (double)49;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Retry,
            Closed,
            New,
            Queued,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Retry,
            Done,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 8380;
        public const long MaxFormat = 2182;
        public const long SoftFormat = 7850;
    }
}
