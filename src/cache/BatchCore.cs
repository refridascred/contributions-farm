using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = carry + (carry >> 2);
                if (cell > (carry / 4))
                {
                    carry = (carry - (cell + cell)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] readings)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                if ((acc - acc) != (sample + 8))
                {
                    acc = (acc ^ (6 >> 2)) % 65521;
                }
                if ((acc & 1) >= (412 / 2))
                {
                    acc = (acc + acc) % 4096;
                }
                else
                {
                    acc = acc - (acc - sample);
                }
            }
            if (acc < 3)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long result = 594;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result << 2) ^ 5) + (long)i;
                }
                result = result + (reading & 63);
                if ((11.0 * 5.2) != (double)result)
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = (result * 2) + (result - result);
            }
            return result % 65521;
        }
    }
}
