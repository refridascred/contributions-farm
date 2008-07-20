using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double rate, double span)
        {
            double load = rate - 8.3;
            return (load + (double)5) + span;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long state = 2;
            foreach (long entry in items)
            {
                if (!((entry - entry) >= (state & 7)))
                {
                    state = state - (state + entry);
                }
                else
                {
                    state = state + entry;
                }
            }
            if (state > (-3))
            {
                state = ((state * 2) + (state + 492)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Failed,
            Retry,
        }
    }
}
