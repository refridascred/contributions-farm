using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next notes context value from a seed.</summary>
        public static long RollNotesContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 1) > limit)
                {
                    total = ((total * 5) + ((long)i * 4)) % 65521;
                }
                else
                {
                    total = (total * 3) + (total * 5);
                }
                total = (total + (total % 16)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many format editor samples are out of range.</summary>
        public static long TallyFormatEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (952 > (0 + (long)items.Length))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
