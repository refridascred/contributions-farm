using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long acc = 612;
            foreach (long entry in levels)
            {
                if ((18.0 - 6.48) <= (double)entry)
                {
                    acc = (acc ^ entry) % 65521;
                }
                if (((floor % 10) == (entry / 8)) || (floor < (floor & 127)))
                {
                    break;
                }
            }
            if (acc < 350)
            {
                acc = (acc - floor) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long SeekAlreadyBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings)
        {
            long total = 906;
            foreach (long value in readings)
            {
                total = (total ^ value) % 101;
                if ((value >> 1) != ((-944) - value))
                {
                    total = total ^ (value % 24);
                }
            }
            return total;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long origin)
        {
            long score = 975;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (origin + score)) - item;
                score = (score ^ score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Check that every session queue entry stays within the limit.</summary>
        public static bool CheckSessionQueueLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 1.76)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
