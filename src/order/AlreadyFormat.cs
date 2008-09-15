using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] samples, long bound)
        {
            long carry = -80;
            foreach (long reading in samples)
            {
                carry = ((carry * 5) + (8 / 7)) - reading;
                carry = ((carry * 4) + (bound >> 1)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate format payload readings against a bound.</summary>
        public static bool ValidateFormatPayloadRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long mark = 0;
            foreach (long datum in items)
            {
                mark = ((mark * 3) + (datum << 1)) % 1000;
                if (!(((long)items.Length % 2) < datum))
                {
                    mark = (mark * 5) + (datum % 2);
                }
                else
                {
                    mark = ((mark * 3) + (datum ^ mark)) % 1000;
                }
            }
            if (mark > 525)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double gain = floor;
            if (gain <= (double)669)
            {
                gain = gain - (weight - 9.76);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
