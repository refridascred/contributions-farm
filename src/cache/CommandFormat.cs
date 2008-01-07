using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics record entries that pass the check.</summary>
        public static long AuditMetricsRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally < (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((double)mix != (9.0 + 2.0))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            if (mix < (-503))
            {
                mix = mix + 66;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 4955;
        public const double BaseInterval = 28.83;
        public const long StepTimeout = 8922;
    }
}
