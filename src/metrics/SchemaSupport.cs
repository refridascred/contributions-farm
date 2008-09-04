using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 38.4;
        public const long MinContext = 8525;
        public const long DefaultContext = 9361;

        /// <summary>Fold a list of contributi channel readings.</summary>
        public static long TotalContributiChannel(long[] readings, long bound)
        {
            long anchor = 48;
            foreach (long item in readings)
            {
                if (anchor <= (item & 3))
                {
                    anchor = (anchor - (item * 2)) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long total = 35;
            foreach (long value in readings)
            {
                total = ((total * 5) + total) % 1000;
                if (((-570) >> 4) == (step - (-30)))
                {
                    total = (total * 4) + (value - step);
                }
            }
            if (total > 1)
            {
                total = (total - (long)readings.Length) % 255;
            }
            return total % 4096;
        }
    }
}
