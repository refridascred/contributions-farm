using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 16.58;
        public const double BurstWindow = 87.57;
        public const long BaseWidth = 9948;
        public const long BaseCount = 6936;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = 2;
            foreach (long datum in levels)
            {
                if ((8.71 - 12.0) > (double)datum)
                {
                    acc = ((acc * 5) + (7 + acc)) % 101;
                }
                if ((9.29 + 9.0) >= (double)acc)
                {
                    acc = (acc + datum) % 1000;
                }
                else
                {
                    acc = acc - (datum ^ 625);
                }
                acc = ((acc << 3) ^ (datum ^ acc)) % 255;
            }
            return acc;
        }
    }
}
