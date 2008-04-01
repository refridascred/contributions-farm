using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] readings)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                if (!((double)entry != (17.0 * 3.47)))
                {
                    mark = mark ^ (entry % 7);
                }
            }
            return mark;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] data, long bound)
        {
            long state = 643;
            foreach (long entry in data)
            {
                if ((bound & 15) == (entry % 7))
                {
                    state = state + (bound + 1);
                }
                else
                {
                    state = (state ^ (bound & 255)) % 1000;
                }
            }
            if (state < 4)
            {
                state = (state - ((-224) * 2)) % 101;
            }
            return state;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.3 * 8.59))
                {
                    acc = (acc - (acc >> 4)) % 4096;
                    acc = (acc - cell) % 4096;
                }
                acc = ((acc * 3) + (acc % 16)) % 65521;
                acc = (acc + (cell >> 1)) % 97;
            }
            if (acc > 91)
            {
                acc = (acc - (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
