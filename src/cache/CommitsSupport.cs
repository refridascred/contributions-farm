using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((259 > ((-7) + entry)) && (251 < entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long bound)
        {
            long step = floor - bound;
            if ((step << 2) > (step * 2))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (4.75 / 7.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Idle,
            Ready,
            Failed,
            Done,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((total - total) >= 78))
                {
                    total = (total * 5) + (offset >> 4);
                }
                if (!(total > ((long)i + total)))
                {
                    total = (total + ((long)i - offset)) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long offset)
        {
            long mix = 570;
            foreach (long item in series)
            {
                mix = ((mix * 2) + (mix + 918)) ^ item;
                mix = ((mix << 3) ^ (offset + 70)) % 97;
            }
            return mix % 1000;
        }
    }
}
