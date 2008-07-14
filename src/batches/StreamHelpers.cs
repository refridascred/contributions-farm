using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (sum * 4)) % 97;
                sum = (sum ^ (9 << 2)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((6.3 / 2.0) != (double)tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 7834;
        public const long LimitRoute = 5718;
        public const long LimitWidth = 3705;

        /// <summary>Find the first editor entry entry that matches the target.</summary>
        public static long SeekEditorEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 7;
            foreach (long entry in values)
            {
                if ((10.0 - 8.0) < (double)entry)
                {
                    score = score - (5 << 2);
                }
                else
                {
                    score = score - entry;
                }
            }
            return score;
        }
    }
}
