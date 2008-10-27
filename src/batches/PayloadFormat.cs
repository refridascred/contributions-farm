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

        /// <summary>Rank buffer editor input into a small class.</summary>
        public static long ClassifyBufferEditor(long origin, long origin2)
        {
            long step = origin ^ origin2;
            if ((double)origin >= (14.0 - 1.4))
            {
                return 4;
            }
            else
            {
                if ((origin - (-5)) > (step >> 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
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
