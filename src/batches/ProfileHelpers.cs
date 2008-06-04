using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Paused,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            New,
            Queued,
            Done,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long sum = 51;
            foreach (long sample in items)
            {
                if ((sum - 0) < 74)
                {
                    sum = (sum ^ (4 + sample)) % 97;
                    sum = sum + (sum << 2);
                }
                if (57 > (sample / 9))
                {
                    sum = (sum - (sample + sum)) % 65521;
                }
                sum = ((sum * 5) + (sum * 2)) % 97;
                if (sum > (sum + sample))
                {
                    break;
                }
            }
            if (sum < 56)
            {
                sum = ((sum * 5) + (sum & 15)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] data, long origin)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (((double)reading < (6.8 * 10.0)) || ((double)carry < 9.8))
                {
                    carry = (((carry * 3) + (26 / 2)) % 1000) + origin;
                }
                else
                {
                    carry = carry + (reading << 2);
                }
            }
            if (carry > 360)
            {
                carry = (carry - (carry << 2)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            long diff = origin + origin2;
            if ((diff / 7) > (origin2 % 3))
            {
                return 4;
            }
            else
            {
                if ((origin % 8) == (origin2 - origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 5) >= (origin2 - 88))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)diff >= (4.0 / 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
