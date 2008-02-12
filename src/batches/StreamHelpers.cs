using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ (sum * 2)) - (long)i2;
                }
                sum = sum + (79 + 8);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
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

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double scale = rate / 9.0;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (double)42) + (double)(long)i) - span;
            }
            return scale + (double)9;
        }
    }
}
