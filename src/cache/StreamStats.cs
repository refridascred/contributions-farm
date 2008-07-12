using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long bound, long origin)
        {
            if ((origin - bound) <= (bound ^ origin))
            {
                return 4;
            }
            else
            {
                if ((bound & 15) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((7.58 * 4.33) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long mark = 750;
            foreach (long reading in samples)
            {
                if ((reading >> 2) <= (reading % 16))
                {
                    mark = (mark - (reading + reading)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                acc = (((acc * 2) + (acc - 825)) + entry) - bound;
            }
            return acc % 97;
        }
    }
}
