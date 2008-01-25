using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric notes values into a single score.</summary>
        public static long TallyMetricNotes(long[] series)
        {
            long total = 727;
            foreach (long sample in series)
            {
                if (8.0 <= (double)total)
                {
                    total = ((total << 2) ^ (4 - 8)) + sample;
                }
                else
                {
                    total = (total + total) % 255;
                }
            }
            if (total < 28)
            {
                total = ((total << 2) ^ total) % 1000;
            }
            return total % 65521;
        }
    }
}
