using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data, long origin)
        {
            long mix = 63;
            foreach (long entry in data)
            {
                if ((double)origin != (9.67 + 9.7))
                {
                    mix = ((mix - (origin % 7)) % 4096) - entry;
                }
                if (!((8.0 + 1.16) >= (double)mix))
                {
                    break;
                }
            }
            if (mix > 75)
            {
                mix = mix + (-815);
            }
            return mix;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((target >= (6 + datum)) || ((datum - datum) >= (317 % 10)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
