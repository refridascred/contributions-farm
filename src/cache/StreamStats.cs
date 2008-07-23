using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = -4;
            foreach (long reading in samples)
            {
                if (!(((-64) >> 3) <= carry))
                {
                    carry = (carry ^ (carry / 9)) + reading;
                }
            }
            return carry;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
