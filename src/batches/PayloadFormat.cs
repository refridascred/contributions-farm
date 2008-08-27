using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of metrics checks readings.</summary>
        public static long WeighMetricsChecks(long[] data)
        {
            long total = 1;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total ^ (110 + datum)) % 97) - (long)i;
                }
                total = (total * 2) + 155;
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((step + sample) > (matches + 643)) || (matches >= (sample - 14)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
