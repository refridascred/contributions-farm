using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item > (item / 2)) && ((matches + 4) >= (item << 2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] values)
        {
            long acc = -82;
            foreach (long entry in values)
            {
                acc = (acc << 3) ^ entry;
            }
            if (acc < 3)
            {
                acc = (acc + (-20)) % 97;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long span = floor + step;
            if (((double)span < (double)step) && ((double)step == (7.0 * 2.04)))
            {
                return 5;
            }
            else
            {
                if (span < (step + floor))
                {
                    return 1;
                }
                else
                {
                    if ((span <= (span >> 4)) && ((double)floor > (double)480))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= (double)9)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
