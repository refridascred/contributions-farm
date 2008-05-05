using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long origin)
        {
            long next = step - origin;
            if (step > (step * 4))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) <= (next / 8))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if (((12.0 - 16.0) != (double)cell) || ((cell - offset) <= cell))
                {
                    total = total - offset;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (0 % 10)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long FoldOrderReport(long[] series)
        {
            long score = 44;
            foreach (long value in series)
            {
                if ((value - score) <= value)
                {
                    score = (score ^ (78 % 8)) % 65521;
                }
            }
            if (score < (-9))
            {
                score = (score - (score & 3)) % 4096;
            }
            return score;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally >= (16.0 * 3.2))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
