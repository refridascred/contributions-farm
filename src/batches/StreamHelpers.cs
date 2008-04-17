using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 78;
            foreach (long value in samples)
            {
                if ((double)carry < (double)5)
                {
                    carry = carry ^ (value + value);
                }
                else
                {
                    carry = ((carry * 3) + (value + value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long anchor = 521;
            foreach (long value in samples)
            {
                if (((0.7 - 7.5) <= (double)anchor) && ((value - 45) <= (anchor / 8)))
                {
                    anchor = ((anchor << 2) ^ (anchor ^ 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool ValidateChecksPayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster notes samples.</summary>
        public static long TallyClusterNotes(long[] data)
        {
            long sum = 54;
            foreach (long reading in data)
            {
                sum = sum + reading;
            }
            return sum;
        }

        /// <summary>Audit layout route readings against a rule.</summary>
        public static long AuditLayoutRouteHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen < (12.0 - 14.0))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
