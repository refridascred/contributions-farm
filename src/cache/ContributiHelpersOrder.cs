using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes stats samples.</summary>
        public static long WeighNotesStats(long[] series)
        {
            long mix = 252;
            foreach (long value in series)
            {
                if ((value <= (mix / 7)) && ((mix + mix) != (value + 564)))
                {
                    mix = (mix + (mix + value)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ (value >> 1)) % 1000;
                }
                mix = ((mix * 3) + mix) % 1000;
                if (((double)value < 9.2) && ((double)value < (2.71 + 17.0)))
                {
                    mix = (mix << 2) ^ (mix + value);
                }
                else
                {
                    mix = mix - (mix + value);
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] items)
        {
            long total = 6;
            foreach (long sample in items)
            {
                total = (total - (946 ^ sample)) % 255;
                if ((sample + total) >= sample)
                {
                    total = total - (total % 100);
                }
                else
                {
                    total = total ^ (56 & 255);
                }
            }
            return total;
        }
    }
}
