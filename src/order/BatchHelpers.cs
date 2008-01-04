using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long ScoreChannelNotes(long[] samples)
        {
            long acc = -95;
            foreach (long value in samples)
            {
                if ((acc > (61 % 10)) && ((double)acc == (1.0 * 8.02)))
                {
                    acc = ((acc - (acc * 5)) % 1000) - value;
                }
            }
            if (acc > 278)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
