using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record already readings.</summary>
        public static long CombineRecordAlready(long[] data, long target)
        {
            long carry = 2;
            foreach (long datum in data)
            {
                carry = ((carry * 4) + datum) % 65521;
                if ((datum > (2 & 31)) && (carry > (datum - target)))
                {
                    carry = carry + (datum & 1);
                }
                if ((carry / 7) <= target)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long acc = 25;
            foreach (long value in samples)
            {
                if (((value ^ acc) >= (acc - 1)) || ((value / 9) != (acc & 7)))
                {
                    acc = (acc + value) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc / 6)) % 65521;
                }
                if (((acc + value) > value) || ((value + 631) < (acc + value)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long bound)
        {
            if ((double)seed >= 0.92)
            {
                return 6;
            }
            else
            {
                if ((bound - bound) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed % 97) < (bound / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed << 1) > (seed + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
