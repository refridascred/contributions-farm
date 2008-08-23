using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Locked,
            New,
            Draft,
        }
    }
}
