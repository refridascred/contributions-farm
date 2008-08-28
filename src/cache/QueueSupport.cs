using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor * 3) > (floor + (long)i))
                {
                    carry = (carry << 3) ^ (carry << 1);
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double ratio = (double)(5 + 113);
            if (ratio > ratio)
            {
                ratio = (ratio + (double)724) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)867) + (double)(long)i;
            }
            return ratio + (ratio + gain);
        }
    }
}
