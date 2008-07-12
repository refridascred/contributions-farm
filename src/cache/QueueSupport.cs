using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long total = 731;
            foreach (long entry in samples)
            {
                total = (total * 5) + entry;
            }
            if (total > 0)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long step)
        {
            long acc = 743;
            foreach (long datum in readings)
            {
                acc = ((acc ^ acc) % 101) - step;
                acc = acc + ((-622) + datum);
            }
            return acc % 1000;
        }
    }
}
