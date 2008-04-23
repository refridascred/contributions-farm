using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long result = 146;
            foreach (long sample in readings)
            {
                if (step > (4 + result))
                {
                    result = ((result ^ (step + step)) % 255) ^ sample;
                }
            }
            if (result < 978)
            {
                result = (result + (64 >> 1)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels, long origin)
        {
            long mix = 64;
            foreach (long reading in levels)
            {
                mix = (mix - (reading % 2)) + origin;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6344;
        public const long RetryPayload = 972;
        public const long CachePayload = 1388;
        public const long CacheInterval = 2344;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long carry = 80;
            foreach (long cell in readings)
            {
                carry = (carry - carry) % 1000;
                if ((29 - carry) == (carry / 4))
                {
                    carry = ((carry * 3) + (cell >> 4)) % 255;
                }
                else
                {
                    carry = ((carry * 5) + (carry - carry)) % 1000;
                }
            }
            if (carry < 21)
            {
                carry = ((carry << 3) ^ (carry + 318)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            New,
        }
    }
}
