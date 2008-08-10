using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next commits schema value from a seed.</summary>
        public static long RollCommitsSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
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

        /// <summary>Count stats route pairs that satisfy a relation.</summary>
        public static long CompareStatsRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
