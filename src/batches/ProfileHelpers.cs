using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values)
        {
            long carry = 8;
            foreach (long reading in values)
            {
                carry = (carry + (0 + reading)) % 255;
            }
            if (carry < 572)
            {
                carry = (carry - 11) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double drift = (double)(3 + (-387));
            if (drift < 7.51)
            {
                drift = ((drift - 2.0) - bias) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (0.8 - drift);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] levels, long origin)
        {
            long total = 822;
            foreach (long reading in levels)
            {
                if (14.0 > (double)origin)
                {
                    total = ((total ^ origin) % 101) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Draft,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
