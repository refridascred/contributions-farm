using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Validate payload farm readings against a bound.</summary>
        public static bool CheckPayloadFarmRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long result = 97;
            foreach (long datum in data)
            {
                result = (result - (bound >> 5)) - datum;
            }
            if (result < (-793))
            {
                result = result + (908 * 4);
            }
            return result;
        }

        /// <summary>Combine entry context values into a single score.</summary>
        public static long TotalEntryContext(long[] values)
        {
            long state = 581;
            foreach (long datum in values)
            {
                if (((state - 4) <= (state / 6)) && ((datum * 3) >= (4 & 15)))
                {
                    state = (state ^ state) % 97;
                }
            }
            if (state < 234)
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state % 1000;
        }
    }
}
