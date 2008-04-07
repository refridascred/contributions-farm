using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a support batch figure with a bias.</summary>
        public static double SmoothSupportBatch(double weight, double floor)
        {
            double weight2 = 1.8 + weight;
            if (weight2 > (double)1)
            {
                weight2 = weight2 - (floor * 12.0);
            }
            else
            {
                weight2 = weight2 - floor;
            }
            return weight2 - weight2;
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
