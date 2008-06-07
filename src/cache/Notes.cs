using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double drift = 1.5;
            if (drift > 4.8)
            {
                drift = (drift - gain) + bias;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (gain - 7.24)) + (double)(long)i;
            }
            return drift + (drift + gain);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long floor)
        {
            long carry = -718;
            foreach (long entry in items)
            {
                if (((59 + carry) == (entry % 16)) || (carry < entry))
                {
                    carry = ((carry * 5) + floor) % 101;
                }
                else
                {
                    carry = carry - (carry << 2);
                }
            }
            if (carry < (-533))
            {
                carry = (carry + (floor >> 2)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((offset <= tally) && (((sample * 3) <= tally) && ((offset - 18) <= (offset % 100))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
