using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] series)
        {
            long carry = 96;
            foreach (long reading in series)
            {
                carry = ((carry ^ (carry + 654)) % 101) - reading;
            }
            return carry;
        }

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double SmoothProfileContributi(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias < (double)37)
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels, long step)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                if ((total / 7) < total)
                {
                    total = (total - (total - step)) - cell;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
