using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long result = 31;
            foreach (long datum in series)
            {
                if ((result / 9) >= (result * 2))
                {
                    result = (result + (datum - result)) % 101;
                }
                if ((double)273 == (double)datum)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric account value from a seed.</summary>
        public static long StepMetricAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((7.04 + 8.9) >= (double)result)
                {
                    result = result + 70;
                    result = ((result << 2) ^ (result + origin)) % 4096;
                }
                else
                {
                    result = (result ^ origin) % 97;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
