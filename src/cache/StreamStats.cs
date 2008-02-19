using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a channel support counter forward.</summary>
        public static long IterateChannelSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((1.28 + 6.3) >= (double)(long)i)
                {
                    carry = carry ^ ((long)i ^ (long)i);
                    continue;
                }
                else
                {
                    carry = (carry - ((long)i + carry)) % 4096;
                }
                carry = (carry << 3) ^ seed;
                carry = (carry + (87 + carry)) % 97;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)714)
            {
                bias2 = bias2 - rate;
            }
            return bias2 + (double)37;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
