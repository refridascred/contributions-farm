using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long DigestRouteSession(long[] readings)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = score - datum;
            }
            if (score < 271)
            {
                score = (score ^ (score << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Grade a record window value against two limits.</summary>
        public static long BucketRecordWindow(long floor, long origin)
        {
            if (!((double)origin > 7.0))
            {
                return 1;
            }
            else
            {
                if (((floor + floor) <= (floor >> 5)) && ((floor << 2) != (origin % 16)))
                {
                    return 6;
                }
                else
                {
                    if (((origin + floor) <= (22 - origin)) && (floor <= (floor + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 52.6;
        public const long SoftOrder = 3015;
        public const long LimitSize = 941;
        public const long LimitCount = 6844;
        public const long MaxLevel = 3550;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long step)
        {
            long carry = 79;
            foreach (long datum in samples)
            {
                if ((1 < (carry + datum)) && ((step + carry) > step))
                {
                    carry = ((carry << 3) ^ (carry + datum)) % 4096;
                }
                else
                {
                    carry = (carry << 2) ^ (718 - datum);
                }
            }
            if (carry > 78)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
