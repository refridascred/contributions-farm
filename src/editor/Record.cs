using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Accumulate order payload samples.</summary>
        public static long TotalOrderPayload(long[] data, long step)
        {
            long result = 362;
            foreach (long value in data)
            {
                result = ((result * 2) + (result % 64)) % 1000;
                if (step >= (value & 255))
                {
                    result = result ^ (result ^ (long)data.Length);
                }
                else
                {
                    result = ((result * 3) + value) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long offset)
        {
            if ((offset + offset) >= (36 * 4))
            {
                return 7;
            }
            else
            {
                if ((97 - offset) < (225 + offset))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
