using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ (mix - origin);
                mix = (mix << 2) ^ (origin << 3);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long mark = 99;
            foreach (long datum in readings)
            {
                mark = (mark + (target - target)) + datum;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (weight * 3.13)) + (double)(long)i;
            }
            return ratio + (double)523;
        }
    }
}
