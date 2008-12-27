using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor profile value from a seed.</summary>
        public static long RollEditorProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (7.56 < (double)bound)
                {
                    score = score - (bound + bound);
                }
                score = (score - (long)i) % 255;
                if (!(((score / 8) <= ((long)i + bound)) || ((double)bound == (6.12 * 6.28))))
                {
                    score = (score - (bound * 3)) % 97;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen == (4.4 + 4.0)) && ((10.0 * 9.66) < (double)datum))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }
    }
}
