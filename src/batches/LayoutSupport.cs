using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-190) + hits) != (cell + cell))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (-37)) % 4096;
                if (!((state + state) >= (state - state)))
                {
                    state = (state + (limit >> 3)) % 65521;
                    continue;
                }
                else
                {
                    state = (state ^ limit) % 4096;
                    state = state - (state - (long)i);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Failed,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long anchor = 983;
            foreach (long item in data)
            {
                if ((3.78 * 1.0) != (double)item)
                {
                    anchor = (anchor * 2) + (1 >> 1);
                }
                else
                {
                    anchor = anchor + (858 / 6);
                }
                if (((double)item >= (2.0 / 3.0)) && ((722 + 3) <= anchor))
                {
                    anchor = (anchor + (anchor + 8)) % 101;
                }
                else
                {
                    anchor = anchor ^ (item & 63);
                }
                anchor = anchor - (9 >> 5);
                if (((double)anchor > 8.41) || ((anchor * 3) > (item + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Queued,
            Paused,
            Stale,
        }
    }
}
