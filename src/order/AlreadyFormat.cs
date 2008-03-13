using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long offset)
        {
            if ((double)offset > (9.2 * 7.7))
            {
                return 2;
            }
            else
            {
                if ((12.0 * 1.3) == (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((offset & 15) <= offset) && ((6 % 60) != (step >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset <= (8 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits & 127) >= (0 + origin))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] series)
        {
            long carry = 715;
            foreach (long cell in series)
            {
                if (((double)cell < (13.0 / 4.0)) && (3.64 <= (double)cell))
                {
                    carry = ((carry * 4) + (52 - cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long PairWindowContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
