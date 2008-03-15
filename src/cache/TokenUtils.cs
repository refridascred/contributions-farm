using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long result = 94;
            foreach (long reading in series)
            {
                result = (result + (reading - result)) % 65521;
                if (result <= (4 - (-1)))
                {
                    result = ((result * 4) + result) % 97;
                }
                else
                {
                    result = ((result << 2) ^ 9) % 101;
                }
                if (((result % 3) >= (result + 32)) && ((reading * 4) >= (reading ^ result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] items)
        {
            long mix = 992;
            foreach (long value in items)
            {
                mix = ((mix ^ (mix + mix)) % 101) - value;
            }
            return mix % 65521;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Queued,
            Idle,
            Failed,
        }
    }
}
