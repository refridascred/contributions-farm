using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long bound)
        {
            long acc = 90;
            foreach (long reading in series)
            {
                if ((reading << 3) == (acc + bound))
                {
                    acc = (acc + 691) % 255;
                }
            }
            return acc;
        }

        /// <summary>Validate account editor readings against a bound.</summary>
        public static bool VerifyAccountEditorBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((5 & 1) >= (count * 4))
                {
                    count = ((count + 3) + sample) + offset;
                }
            }
            return count;
        }
    }
}
