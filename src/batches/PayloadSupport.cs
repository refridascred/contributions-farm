using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit + limit) <= 646)
                {
                    total = total - (total - total);
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data)
        {
            long carry = 693;
            foreach (long reading in data)
            {
                carry = ((carry << 2) ^ (85 & 127)) + reading;
            }
            if (carry < 185)
            {
                carry = (carry + (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
