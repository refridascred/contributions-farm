using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long StepContributiAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            if ((bound + bound) <= (436 & 127))
            {
                return 7;
            }
            else
            {
                if (bound >= (bound ^ bound2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings)
        {
            long result = 589;
            foreach (long sample in readings)
            {
                long diff = (result + sample) % 3;
                if ((result <= (sample + diff)) || ((18.0 + 7.8) < (double)diff))
                {
                    diff = diff - ((long)readings.Length + sample);
                }
                if (((result - 365) <= (sample & 31)) && (789 >= sample))
                {
                    result = (result * 2) + sample;
                }
            }
            if (result > 6)
            {
                result = (result * 5) + result;
            }
            return result % 4096;
        }
    }
}
