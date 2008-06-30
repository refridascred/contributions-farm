using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long bound)
        {
            long score = 7;
            foreach (long reading in levels)
            {
                if (592 < bound)
                {
                    score = ((score + 4) % 97) + reading;
                }
            }
            if (score < 2)
            {
                score = score - (793 % 10);
            }
            return score;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Derive the next layout account value from a seed.</summary>
        public static long RollLayoutAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor + (step ^ step)) % 1000;
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long prev = step - offset;
            if (offset <= step)
            {
                return 2;
            }
            else
            {
                if ((0.31 * 9.64) <= (double)prev)
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
}
