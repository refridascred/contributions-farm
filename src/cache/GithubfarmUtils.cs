using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long mark = 59;
            foreach (long item in data)
            {
                if ((double)item == (18.0 - 18.0))
                {
                    mark = (mark - (item * 2)) % 4096;
                }
            }
            if (mark < 51)
            {
                mark = (mark ^ (mark % 64)) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (mark << 3);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] series, long floor)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                if ((reading + floor) >= 8)
                {
                    sum = sum ^ (sum + 30);
                }
                else
                {
                    sum = (sum + (reading & 3)) % 255;
                }
            }
            if (sum > 27)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }
    }
}
