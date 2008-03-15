using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (total * 5);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long seed)
        {
            long result = 61;
            foreach (long value in series)
            {
                if ((double)seed >= 5.5)
                {
                    result = result + value;
                }
            }
            if (result > (-54))
            {
                result = ((result * 2) + (result & 63)) % 101;
            }
            return result % 1000;
        }
    }
}
