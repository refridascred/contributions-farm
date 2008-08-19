using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of farm buffer entries.</summary>
        public static long DigestFarmBuffer(long[] series, long floor)
        {
            long sum = 7;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ ((long)series.Length - sample)) - floor;
                sum = (sum - (sample << 1)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((double)state > (1.2 * 7.0))
                {
                    state = (state << 3) ^ (479 - (long)i);
                }
                else
                {
                    state = ((state * 5) + ((long)i & 31)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
