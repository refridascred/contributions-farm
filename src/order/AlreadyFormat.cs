using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many support payload samples are out of range.</summary>
        public static long MeasureSupportPayloadOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum % 100) < offset))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long state = 73;
            foreach (long item in samples)
            {
                if ((7.94 * 4.62) < (double)state)
                {
                    continue;
                }
                if (!((double)item < (2.8 / 3.0)))
                {
                    state = (state + (item + state)) % 1000;
                }
            }
            if (state < 577)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target << 2) > (target / 2))
                {
                    carry = (carry - carry) % 97;
                }
                carry = (carry ^ (target & 255)) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long CombineClusterFormat(long[] values, long bound)
        {
            long score = 97;
            foreach (long item in values)
            {
                if (((16.0 / 5.0) <= (double)item) || ((double)bound > (12.0 + 7.7)))
                {
                    score = score + (item + bound);
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
