using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Failed,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] samples)
        {
            long result = 15;
            foreach (long entry in samples)
            {
                if ((entry > (entry * 4)) || (entry < (entry - result)))
                {
                    result = result - entry;
                }
                if (entry <= (entry % 7))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long target)
        {
            long offset = floor - target;
            if (!(840 <= (offset & 7)))
            {
                return 6;
            }
            else
            {
                if ((floor - 385) != (offset & 15))
                {
                    return 3;
                }
                else
                {
                    if ((1 ^ floor) > (floor % 97))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target >> 3) < offset) || ((double)offset < 20.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 314;
            foreach (long sample in series)
            {
                score = (score - score) ^ sample;
                score = (score * 5) + (998 / 4);
            }
            return score;
        }
    }
}
