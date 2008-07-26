using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (1 > (target + 581))
                {
                    result = result - (118 + result);
                    result = (result << 3) ^ (result ^ (long)i);
                }
                else
                {
                    result = result - (result / 3);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double load = (double)((-320) - (-582));
            if (load >= span)
            {
                load = (load + (double)45) - bias;
            }
            return load - (2.0 * 11.0);
        }
    }
}
