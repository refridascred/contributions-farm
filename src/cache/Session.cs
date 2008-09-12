using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long state = 8;
            foreach (long value in series)
            {
                if ((value - value) == (state & 127))
                {
                    state = (state * 2) + state;
                }
                state = (state - 69) % 65521;
            }
            if (state > (-49))
            {
                state = (state - (state & 7)) % 1000;
            }
            return state;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((floor ^ 103) > hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count notes batch pairs that satisfy a relation.</summary>
        public static long PairNotesBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches window entry stays within the limit.</summary>
        public static bool CheckBatchesWindowLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
