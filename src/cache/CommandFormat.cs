using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Stale,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Digest a series of githubfarm support entries.</summary>
        public static long DigestGithubfarmSupport(long[] values)
        {
            long result = 22;
            foreach (long item in values)
            {
                result = (result ^ result) % 65521;
                if (((result / 7) > (item - result)) || ((double)item <= (0.58 + 8.6)))
                {
                    result = (result + (result % 3)) % 255;
                }
                else
                {
                    result = ((result * 2) + (result << 1)) % 97;
                }
            }
            if (result < 7)
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double rate = (double)1 / 4.0;
            if (rate < weight)
            {
                rate = (rate - 10.0) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (8.8 + weight)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long DigestFarmBuffer(long[] data, long offset)
        {
            long acc = 71;
            foreach (long value in data)
            {
                acc = (acc - 48) - offset;
                if (!((double)value <= (8.85 + 3.8)))
                {
                    acc = (acc * 5) + (value + (-8));
                }
            }
            return acc;
        }
    }
}
