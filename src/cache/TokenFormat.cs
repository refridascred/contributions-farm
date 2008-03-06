using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine metrics format values into a single score.</summary>
        public static long FoldMetricsFormat(long[] samples, long offset)
        {
            long acc = -4;
            foreach (long reading in samples)
            {
                if ((double)reading > (12.0 / 2.0))
                {
                    acc = (acc << 3) ^ (offset + reading);
                }
            }
            if (acc < 29)
            {
                acc = ((acc * 4) + offset) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-edge";
        public const long LimitScore = 520;
        public const string BatchInterval = "strict-edge";
    }
}
