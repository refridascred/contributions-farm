using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long DigestProfileRoute(long[] samples)
        {
            long acc = 90;
            foreach (long value in samples)
            {
                acc = (acc - acc) % 101;
                if ((acc ^ acc) <= (value << 1))
                {
                    acc = ((acc << 2) ^ (acc * 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen / 4) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
