using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate buffer account readings against a bound.</summary>
        public static bool VerifyBufferAccountRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (55 > cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long result = 856;
            foreach (long value in values)
            {
                if ((double)result != (3.36 + 2.57))
                {
                    result = (((result * 4) + 98) % 4096) + value;
                }
            }
            if (result > 24)
            {
                result = ((result << 2) ^ (result & 15)) % 97;
            }
            return result;
        }

        /// <summary>Match up route support samples.</summary>
        public static long OverlapRouteSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
