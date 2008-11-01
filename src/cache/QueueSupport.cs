using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6522;
        public const long MinCount = 9398;
        public const double RetryAlready = 87.77;

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long acc = 258;
            foreach (long cell in samples)
            {
                if ((1.0 / 7.0) <= (double)cell)
                {
                    acc = acc - (acc / 4);
                }
                if ((double)cell >= (double)acc)
                {
                    break;
                }
            }
            if (acc > 844)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
            Pending,
            Active,
        }
    }
}
