using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 452;
            foreach (long reading in levels)
            {
                result = result ^ (result ^ reading);
                if (((double)989 >= (double)result) && ((6.4 - 4.6) > (double)origin))
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchDepth = 8555;
        public const long DefaultCluster = 9191;
        public const double BatchCluster = 54.7;
        public const string SoftInterval = "open-1";

        /// <summary>Fold a list of route order readings.</summary>
        public static long ScoreRouteOrder(long[] samples)
        {
            long carry = 3;
            foreach (long cell in samples)
            {
                if (((cell >> 3) >= (cell - cell)) || (carry < (cell + cell)))
                {
                    carry = (carry ^ (carry >> 3)) % 4096;
                }
                else
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((carry - carry) <= (cell & 255))
                {
                    break;
                }
            }
            if (carry > 974)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long offset)
        {
            if (!((target + offset) > (offset >> 4)))
            {
                return 8;
            }
            else
            {
                if ((offset ^ offset) < (offset << 3))
                {
                    return 3;
                }
                else
                {
                    if ((target * 4) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset ^ 80) <= (target + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Stale,
            Ready,
            Idle,
        }
    }
}
