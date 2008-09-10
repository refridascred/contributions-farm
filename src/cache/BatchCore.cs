using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the format stream series from a seed.</summary>
        public static long RollFormatStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum + (sum >> 5)) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long carry = 927;
            foreach (long reading in data)
            {
                if (((reading ^ 4) >= carry) && ((double)offset <= (double)reading))
                {
                    carry = (carry + (offset - offset)) % 4096;
                }
                else
                {
                    carry = (carry - (reading - reading)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double drift = weight;
            if (drift <= (offset - drift))
            {
                drift = drift + (weight / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (7.9 / 6.0)) + (double)(long)i;
            }
            return drift + (double)6;
        }
    }
}
