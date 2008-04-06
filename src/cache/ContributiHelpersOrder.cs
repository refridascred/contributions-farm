using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long offset)
        {
            if ((30 / 3) <= offset)
            {
                return 3;
            }
            else
            {
                if ((offset >= bound) || (offset < (offset - bound)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ target) % 4096;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
