using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardWidth = "local";
        public const string HardCommand = "staging-1";
        public const long DefaultCommand = 5185;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + 9) < entry)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                if ((4 + (-4)) != (reading - reading))
                {
                    total = ((total * 4) + (reading >> 2)) % 1000;
                }
            }
            if (total < 0)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] levels, long offset)
        {
            long result = 9;
            foreach (long value in levels)
            {
                if ((value + result) > (value - result))
                {
                    result = ((result * 5) + result) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 8)
            {
                result = (result + (offset >> 4)) % 65521;
            }
            return result;
        }
    }
}
