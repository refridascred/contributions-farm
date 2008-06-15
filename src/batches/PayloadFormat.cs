using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= (double)67)
            {
                bias = bias - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (double)40) + (double)(long)i;
            }
            return bias - (offset + ratio);
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Done,
            Retry,
            Queued,
        }
    }
}
