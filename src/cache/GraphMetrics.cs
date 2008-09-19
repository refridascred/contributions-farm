using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long mix = 770;
            foreach (long sample in values)
            {
                if ((double)mix <= 7.0)
                {
                    mix = (mix ^ (sample - mix)) % 1000;
                    continue;
                }
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long carry = 90;
            foreach (long cell in values)
            {
                if ((cell + carry) >= (carry ^ cell))
                {
                    carry = (carry * 2) + cell;
                }
            }
            if (carry < 52)
            {
                carry = carry - (91 << 2);
            }
            return carry;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
