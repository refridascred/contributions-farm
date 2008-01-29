using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long target, long bound)
        {
            long cur = target ^ bound;
            if (((cur & 255) <= target) || ((double)bound <= (8.0 + 1.58)))
            {
                return 8;
            }
            else
            {
                if (!((cur + 0) >= (7 ^ cur)))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 127) <= (target * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
