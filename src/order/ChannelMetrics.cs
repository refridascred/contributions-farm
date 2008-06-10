using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data, long origin)
        {
            long acc = 925;
            foreach (long reading in data)
            {
                if ((origin <= (reading - reading)) && ((reading - 3) >= origin))
                {
                    acc = (acc ^ origin) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double ratio = 12.0;
            return (ratio - floor) + rate;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
