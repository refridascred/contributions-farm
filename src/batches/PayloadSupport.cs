using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long target)
        {
            long acc = 26;
            foreach (long sample in samples)
            {
                if ((acc >> 2) > (sample - sample))
                {
                    acc = ((acc * 5) + (8 % 100)) - target;
                }
                if ((acc + acc) == ((long)samples.Length / 7))
                {
                    acc = (acc ^ sample) % 65521;
                }
            }
            if (acc > 45)
            {
                acc = acc - (acc << 3);
            }
            return acc;
        }
    }
}
