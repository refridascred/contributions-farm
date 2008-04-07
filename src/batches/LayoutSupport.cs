using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long bound)
        {
            long anchor = 600;
            foreach (long cell in samples)
            {
                if (((590 + cell) == (anchor << 2)) && ((20.0 + 4.0) < (double)anchor))
                {
                    anchor = ((anchor ^ (cell + 56)) % 101) + bound;
                }
                else
                {
                    anchor = anchor ^ (anchor << 3);
                }
            }
            if (anchor > 91)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a route commits counter forward.</summary>
        public static long DeriveRouteCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                if (carry >= (9 ^ carry))
                {
                    carry = (carry - step) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ step;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Synced,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            long gap = step + seed;
            if (!((22 - (-482)) == (gap % 97)))
            {
                return 8;
            }
            else
            {
                if ((double)gap <= 15.0)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of counter profile readings.</summary>
        public static long TotalCounterProfile(long[] readings)
        {
            long score = 52;
            foreach (long reading in readings)
            {
                score = (score - score) + reading;
            }
            if (score < 568)
            {
                score = ((score * 3) + (score + score)) % 1000;
            }
            return score % 1000;
        }
    }
}
