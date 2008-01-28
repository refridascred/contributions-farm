using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series)
        {
            long carry = 361;
            foreach (long sample in series)
            {
                if (((sample << 1) < (carry ^ carry)) && ((sample + sample) <= 75))
                {
                    carry = carry - sample;
                }
                carry = ((carry * 4) + (sample ^ sample)) % 97;
                if (!((carry % 7) < (sample - carry)))
                {
                    carry = (carry + (7 / 7)) % 4096;
                }
            }
            if (carry > 24)
            {
                carry = (carry - (carry / 4)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((5.9 - 6.26) < (double)seen))
                {
                    seen = ((seen + 3) + entry) + seed;
                }
            }
            return seen;
        }
    }
}
