using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route report samples.</summary>
        public static long FoldRouteReport(long[] values, long bound)
        {
            long total = -3;
            foreach (long item in values)
            {
                if ((3 + bound) > (70 - item))
                {
                    total = (total - (bound * 2)) % 65521;
                }
            }
            if (total < (-204))
            {
                total = total ^ bound;
            }
            return total % 65521;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
