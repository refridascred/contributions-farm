using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((sum << 1) == (bound + bound))
                {
                    sum = (sum + ((long)i - (long)i)) % 97;
                }
                else
                {
                    sum = sum ^ (bound + sum);
                    sum = sum - ((long)i & 3);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long result = 474;
            foreach (long value in items)
            {
                result = ((result << 2) ^ (value - result)) % 101;
            }
            return result % 97;
        }

        /// <summary>Find the first profile editor entry that matches the target.</summary>
        public static long LookupProfileEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
