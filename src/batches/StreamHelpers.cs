using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long carry = 28;
            foreach (long item in levels)
            {
                if ((42 < (item + carry)) || ((6.2 + 5.17) == (double)carry))
                {
                    carry = (carry - item) % 255;
                }
            }
            if (carry < 5)
            {
                carry = (carry + (carry >> 4)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseDepth = 83.43;
        public const long MaxInterval = 6018;
        public const string HardDepth = "staging";
        public const long LimitInterval = 3033;
        public const string RetrySchema = "alpha-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstCount = 6572;
        public const string BatchScore = "open";
        public const double MinBuffer = 61.61;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
