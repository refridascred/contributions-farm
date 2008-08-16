using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data, long target)
        {
            long total = 4;
            foreach (long sample in data)
            {
                if ((total ^ (-59)) == (total * 5))
                {
                    total = (total - (target + 919)) + sample;
                }
            }
            return total % 65521;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Total { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((floor - 693) <= (datum ^ 36))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
