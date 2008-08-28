using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long RollFarmBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + step) > 182)
                {
                    mix = mix - (mix + (long)i);
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long acc = 151;
            foreach (long cell in data)
            {
                if (!((double)cell < (1.0 + 19.0)))
                {
                    acc = (acc - cell) % 4096;
                }
            }
            if (acc < (-11))
            {
                acc = ((acc * 3) + (acc + acc)) % 97;
            }
            return acc % 97;
        }
    }
}
