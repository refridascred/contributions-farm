using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (score >> 1)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + ((long)i ^ step)) % 101;
                if ((step >> 5) > (long)i)
                {
                    carry = ((carry << 2) ^ (carry % 8)) % 97;
                    carry = ((carry << 3) ^ ((long)i - step)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a notes layout value against two limits.</summary>
        public static long BucketNotesLayout(long target, long origin)
        {
            long cur = target - origin;
            if ((cur - cur) < 5)
            {
                return 1;
            }
            else
            {
                if ((cur + 0) < (1 << 3))
                {
                    return 7;
                }
                else
                {
                    if (!((origin >> 3) != ((-50) ^ origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long total = 170;
            foreach (long reading in data)
            {
                if ((reading / 9) > (total + reading))
                {
                    total = (total + (total << 1)) % 1000;
                }
                else
                {
                    total = total ^ (total - total);
                }
            }
            return total % 1000;
        }
    }
}
