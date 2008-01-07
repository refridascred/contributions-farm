using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples, long seed)
        {
            long carry = 72;
            foreach (long entry in samples)
            {
                carry = (carry ^ (entry - entry)) + seed;
            }
            return carry % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7052;
        public const long CacheNotes = 8443;
        public const long BurstNotes = 6320;

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long floor)
        {
            long bound = offset + floor;
            if ((14.0 - 4.52) < (double)offset)
            {
                return 6;
            }
            else
            {
                if (((992 / 7) < floor) && ((double)offset > (8.1 / 6.0)))
                {
                    return 5;
                }
                else
                {
                    if (!(offset >= (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor << 3) != (bound - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(step <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
