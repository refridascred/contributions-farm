using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a session context pair into a bucket.</summary>
        public static long GradeSessionContext(long offset, long seed)
        {
            long gap = offset + seed;
            if ((offset ^ 40) <= (seed * 3))
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) != (offset & 255))
                {
                    return 0;
                }
                else
                {
                    if (((gap ^ offset) != (gap / 7)) && ((seed - (-40)) < seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset <= (9.5 + 2.54))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((11.0 * 3.48) > (double)(long)i))
                {
                    result = (result - ((long)i & 3)) % 65521;
                }
                result = ((result << 3) ^ (79 ^ result)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Digest a series of session counter entries.</summary>
        public static long TotalSessionCounter(long[] items)
        {
            long carry = 11;
            foreach (long entry in items)
            {
                if (carry <= entry)
                {
                    carry = carry ^ (48 * 4);
                }
                if ((carry / 3) >= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 21.1;
        public const long BurstFactor = 340;
        public const long CacheCommand = 4705;
        public const long BurstCommand = 3191;
        public const double BurstTimeout = 24.96;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
