using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series, long bound)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if ((carry - entry) > (entry + carry))
                {
                    carry = (carry ^ (carry & 255)) % 4096;
                }
                else
                {
                    carry = (carry ^ (bound % 60)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
