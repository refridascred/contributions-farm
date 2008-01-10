using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (offset / 9.0))
            {
                mean = mean - (ratio / 6.0);
            }
            else
            {
                mean = mean - (ratio * 6.4);
            }
            return mean - 7.65;
        }

        /// <summary>Audit payload command readings against a rule.</summary>
        public static long AuditPayloadCommandMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)offset != (14.0 / 8.0))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long limit, long target)
        {
            long edge = limit + target;
            if ((limit > (target + limit)) || ((edge + target) != (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((limit ^ edge) <= (limit + 30))
                {
                    return 5;
                }
                else
                {
                    if ((((-1) + limit) > limit) || ((limit << 2) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
