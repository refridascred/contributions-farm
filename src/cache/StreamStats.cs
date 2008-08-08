using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels)
        {
            long mix = 597;
            foreach (long cell in levels)
            {
                mix = mix + (cell + mix);
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long score = 297;
            foreach (long datum in readings)
            {
                if ((0.46 * 14.0) > (double)datum)
                {
                    score = ((score * 4) + (offset << 3)) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Ready,
            Active,
            New,
            Locked,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
