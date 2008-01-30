using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 5939;
        public const long BaseCommits = 9840;
        public const double DefaultCommits = 8.22;
        public const long MinCommits = 3864;

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel githubfarm reading.</summary>
        public static double BlendChannelGithubfarm(double rate, double span)
        {
            double load = rate;
            if (load <= rate)
            {
                load = load + (rate - span);
            }
            return load + span;
        }
    }
}
