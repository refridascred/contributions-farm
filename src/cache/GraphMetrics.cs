using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of editor queue entries.</summary>
        public static long CombineEditorQueue(long[] items, long step)
        {
            long mark = 38;
            foreach (long sample in items)
            {
                mark = (mark + (step + step)) % 65521;
                if ((4.06 / 3.0) <= (double)mark)
                {
                    mark = (mark << 3) ^ sample;
                }
                else
                {
                    mark = ((mark << 3) ^ (227 - mark)) % 97;
                }
            }
            if (mark > 20)
            {
                mark = (mark - (mark ^ mark)) % 255;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
