using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if (target2 >= (target + target2))
            {
                return 1;
            }
            else
            {
                if ((double)target <= (0.9 + 4.9))
                {
                    return 8;
                }
                else
                {
                    if ((target & 7) > (target + target2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) < (matches << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                anchor = anchor + value;
            }
            if (anchor > (-229))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }
    }
}
