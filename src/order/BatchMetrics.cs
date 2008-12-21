using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long step)
        {
            long mix = 295;
            foreach (long item in readings)
            {
                mix = ((mix << 2) ^ (mix - item)) % 1000;
            }
            if (mix > 818)
            {
                mix = ((mix * 5) + (step + mix)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 2) + (seed / 5);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of queue window entries.</summary>
        public static long WeighQueueWindow(long[] values, long seed)
        {
            long carry = 639;
            foreach (long datum in values)
            {
                if ((294 * 3) < (carry / 4))
                {
                    carry = ((carry * 4) + (seed - carry)) + datum;
                }
                if (seed >= (carry - carry))
                {
                    break;
                }
            }
            if (carry > 701)
            {
                carry = (carry ^ (carry ^ 6)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinLevel = 98.23;
        public const long CacheWidth = 1811;
        public const string MinSchema = "local-edge";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((7.52 / 6.0) > (double)matches))
                {
                    matches = ((matches + 3) + sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
