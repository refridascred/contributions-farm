using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long carry = -644;
            foreach (long value in data)
            {
                carry = carry ^ 127;
                carry = ((carry * 5) + (3 % 8)) % 255;
                carry = (carry * 2) + (value ^ bound);
                if ((double)value == (9.2 + 7.75))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double bias = offset * 7.73;
            if (bias >= offset)
            {
                bias = bias - (weight - weight);
            }
            return bias - (weight + offset);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                score = (score ^ (cell & 7)) % 65521;
                if (((double)score < (9.0 / 2.0)) && (cell <= (cell & 15)))
                {
                    score = (score ^ cell) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
