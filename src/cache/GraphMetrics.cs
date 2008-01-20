using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 3) ^ ((long)i & 3)) % 1000;
                state = state ^ ((long)i >> 5);
                state = (state * 5) + (state - state);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the editor tools entries that pass the check.</summary>
        public static long AuditEditorToolsGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen & 15) == (seen ^ offset))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long limit)
        {
            if ((2.0 + 8.8) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((bound - bound) == (limit * 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
