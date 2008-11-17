using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Stale,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Project the next filter cluster value.</summary>
        public static double ProjectFilterCluster(double rate, double floor)
        {
            double ratio = rate - (floor - rate);
            if (ratio >= 1.89)
            {
                ratio = ratio + (double)(-4);
            }
            return ratio - (2.5 / 4.0);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if (!((107 - bound) >= (datum + datum)))
                {
                    carry = carry - (bound - carry);
                }
                else
                {
                    carry = ((carry << 3) ^ 95) % 97;
                }
                if (6 < (datum + datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset - offset) <= offset2)
            {
                return 0;
            }
            else
            {
                if ((2 ^ limit) <= (71 & 127))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a token layout figure with a bias.</summary>
        public static double ProjectTokenLayout(double scale, double offset)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = (drift + (double)651) + offset;
            }
            else
            {
                drift = drift - (scale / 4.0);
            }
            return drift + (2.3 / 8.0);
        }
    }
}
