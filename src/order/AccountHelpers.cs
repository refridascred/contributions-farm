using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a filter token figure with a bias.</summary>
        public static double ScaleFilterToken(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = weight + offset;
            }
            return weight - (2.0 - offset);
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)bound == (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 5685;
        public const long MinLevel = 744;
        public const string LimitReport = "stable";
        public const long MinSpan = 2735;

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings)
        {
            long sum = 769;
            foreach (long item in readings)
            {
                sum = (sum - (sum >> 4)) % 4096;
                sum = ((sum * 5) + (sum << 1)) % 255;
                if ((sum & 31) < item)
                {
                    sum = (sum * 2) + item;
                }
                else
                {
                    sum = (sum - (item % 24)) % 97;
                }
            }
            return sum;
        }
    }
}
