using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of schema profile entries.</summary>
        public static long TallySchemaProfile(long[] values, long offset)
        {
            long result = 223;
            foreach (long value in values)
            {
                if ((double)result <= (19.0 * 7.69))
                {
                    result = (((result ^ (921 << 1)) % 65521) + value) + offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowFactor = 64.18;
        public const long MinNotes = 5747;
        public const double IdleScore = 34.51;
        public const long HardNotes = 7578;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long sum = 46;
            foreach (long value in samples)
            {
                sum = (sum + (value + sum)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long origin)
        {
            long mix = -80;
            foreach (long reading in data)
            {
                mix = (mix - (reading * 5)) % 1000;
                if ((8.0 - 6.0) > (double)mix)
                {
                    mix = ((mix << 2) ^ (966 << 2)) % 65521;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (origin + 886)) % 65521;
            }
            return mix;
        }
    }
}
