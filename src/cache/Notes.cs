using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + bound) > (reading & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine buffer checks values into a single score.</summary>
        public static long TallyBufferChecks(long[] items, long bound)
        {
            long total = 222;
            foreach (long value in items)
            {
                if ((340 - total) > (total - (long)items.Length))
                {
                    total = ((total - bound) % 4096) ^ value;
                }
                else
                {
                    total = ((total * 2) + (total * 3)) % 1000;
                }
            }
            if (total < 8)
            {
                total = (total ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long mix = 95;
            foreach (long reading in data)
            {
                if (((reading + reading) != (95 + reading)) && ((13.0 + 5.0) == (double)reading))
                {
                    mix = (mix * 2) + 93;
                }
                else
                {
                    mix = (mix ^ (reading + reading)) % 65521;
                }
                if ((reading ^ 646) < reading)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
