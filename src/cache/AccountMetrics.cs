using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (limit - (long)i);
                mix = mix - limit;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a window notes reading.</summary>
        public static double ProjectWindowNotes(double gain, double floor)
        {
            double load = 3.58;
            return ((load - load) + gain) + floor;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Stale,
            Ready,
            New,
            Retry,
        }

        /// <summary>Combine session already values into a single score.</summary>
        public static long CombineSessionAlready(long[] values)
        {
            long state = -77;
            foreach (long reading in values)
            {
                if ((reading + reading) <= (state - reading))
                {
                    state = ((state * 3) + (reading ^ state)) % 255;
                }
            }
            if (state < 0)
            {
                state = (state << 2) ^ (state << 1);
            }
            return state % 1000;
        }
    }
}
