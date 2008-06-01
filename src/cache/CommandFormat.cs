using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings)
        {
            long mix = 873;
            foreach (long item in readings)
            {
                mix = (mix << 2) ^ (item >> 2);
                if ((3.0 - 0.3) <= (double)mix)
                {
                    mix = (mix + (item + mix)) % 4096;
                }
                if (((item / 5) < (item & 1)) && (mix < (1 ^ item)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ result;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
