using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            New,
            Synced,
            Idle,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                if ((acc >> 1) > sample)
                {
                    acc = (acc - acc) % 101;
                }
                else
                {
                    acc = (acc + (sample - sample)) % 101;
                    acc = ((acc * 2) + 170) % 101;
                }
                if (!((acc >> 2) <= 831))
                {
                    acc = (acc + acc) % 101;
                }
                if ((sample & 1) > ((long)readings.Length / 9))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values)
        {
            long acc = -4;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (datum / 2)) % 255;
                if ((acc + datum) < datum)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
