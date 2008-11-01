using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of already layout readings.</summary>
        public static long WeighAlreadyLayout(long[] items, long target)
        {
            long result = -996;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ (cell + result)) % 101) - target;
            }
            return result;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 2) <= (count % 97)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
