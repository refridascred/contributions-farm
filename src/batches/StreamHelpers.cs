using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((double)(long)i <= (10.0 - 5.0)) && (10.0 >= (double)carry))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry ^ (seed << 3)) % 1000;
                }
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < 15.0)
            {
                ratio = (ratio - (double)472) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels, long offset)
        {
            long carry = 988;
            foreach (long reading in levels)
            {
                carry = (((carry << 2) ^ (reading & 127)) % 255) + offset;
                if ((carry < (reading - reading)) || ((carry >> 2) != (17 + 25)))
                {
                    carry = (carry << 3) ^ (carry >> 3);
                }
                else
                {
                    carry = ((carry * 2) + (carry + 5)) % 255;
                }
            }
            if (carry > 54)
            {
                carry = carry ^ (carry % 10);
            }
            return carry % 4096;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Retry,
            Draft,
        }
    }
}
