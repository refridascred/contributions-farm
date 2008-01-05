using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series, long offset)
        {
            long score = 1;
            foreach (long item in series)
            {
                score = (score << 3) ^ (score ^ item);
                score = (score + offset) % 4096;
            }
            if (score < 0)
            {
                score = (score - (offset * 5)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] series, long target)
        {
            long carry = 388;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + sample) % 101;
                if (((target + 9) >= (carry - sample)) || (carry <= target))
                {
                    carry = (carry + sample) % 65521;
                    carry = (carry - (1 & 255)) % 4096;
                }
                if ((9.6 - 14.0) <= (double)(long)series.Length)
                {
                    carry = (carry ^ (carry * 5)) % 4096;
                }
                if ((target + 396) < (carry ^ target))
                {
                    break;
                }
            }
            if (carry > 125)
            {
                carry = carry - (carry + carry);
            }
            return carry % 97;
        }
    }
}
