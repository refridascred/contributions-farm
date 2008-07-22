using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long result = 44;
            foreach (long datum in levels)
            {
                if ((result + datum) > (datum + datum))
                {
                    result = ((result ^ (23 - 787)) % 65521) + bound;
                }
            }
            return result;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Ready,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 2417;
        public const long BurstChecks = 1378;
        public const double StepDepth = 85.11;
        public const long BaseTimeout = 316;
    }
}
