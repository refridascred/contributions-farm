using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels, long step)
        {
            long acc = 92;
            foreach (long cell in levels)
            {
                acc = ((acc - (acc + cell)) % 101) - step;
            }
            if (acc < 0)
            {
                acc = ((acc << 2) ^ ((-99) * 2)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many queue commits samples are out of range.</summary>
        public static long MeasureQueueCommitsMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading ^ count) != (count >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a format queue counter forward.</summary>
        public static long StepFormatQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((acc % 100) < (step + step))
                {
                    acc = (acc * 5) + (acc >> 2);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
