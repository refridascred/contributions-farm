using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels)
        {
            long sum = 97;
            foreach (long cell in levels)
            {
                if ((sum ^ 0) < (cell ^ 9))
                {
                    sum = ((sum * 4) + (sum << 1)) % 65521;
                }
            }
            if (sum > 254)
            {
                sum = (sum ^ (841 ^ 63)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Roll a metric stream counter forward.</summary>
        public static long IterateMetricStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)bound != (4.62 * 11.0)))
                {
                    anchor = (anchor ^ (bound & 255)) % 101;
                }
                anchor = (anchor * 3) + (19 & 255);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool VerifyFarmPayloadRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Dropped,
            Pending,
            Draft,
            Failed,
        }
    }
}
