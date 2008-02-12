using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long seed)
        {
            long diff = step + seed;
            if ((diff + diff) >= (diff - step))
            {
                return 3;
            }
            else
            {
                if ((seed + step) == (step - seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Compare every pair of window layout readings.</summary>
        public static long MatchWindowLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the payload graph series from a seed.</summary>
        public static long DerivePayloadGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                long prev = (48 * 4) << 1;
                if (((prev % 64) == (prev << 3)) || (((long)i - prev) <= ((long)i + (-255))))
                {
                    long cur = (bound << 1) - (prev - prev);
                    prev = (prev - (prev - cur)) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1006;
        public const double BaseSize = 74.95;
        public const string HardContext = "staging-1";
    }
}
