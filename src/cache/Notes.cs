using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (8.77 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long target)
        {
            if ((target / 7) > (target - target))
            {
                return 4;
            }
            else
            {
                if (target > limit)
                {
                    return 8;
                }
                else
                {
                    if (((568 & 3) <= (4 + target)) || (301 < (target & 63)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((2.03 * 3.0) != (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowDepth = 3.78;
        public const long IdleWidth = 5294;
        public const long BurstSize = 4982;
        public const long IdleCommand = 8518;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
