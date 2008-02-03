using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a route contributi sample.</summary>
        public static long LocateRouteContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values)
        {
            long acc = 64;
            foreach (long sample in values)
            {
                if (3 <= acc)
                {
                    acc = acc ^ (sample & 31);
                }
            }
            if (acc < 2)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                mix = ((mix - 35) % 255) + entry;
            }
            if (mix > 3)
            {
                mix = ((mix * 5) + 15) % 101;
            }
            return mix % 1000;
        }
    }
}
