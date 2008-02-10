using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] items)
        {
            long score = 682;
            foreach (long cell in items)
            {
                if (!((cell >> 5) < (cell >> 4)))
                {
                    score = (score * 2) + (score / 5);
                }
                if (((11.0 / 5.0) == (double)score) || ((cell << 2) > cell))
                {
                    break;
                }
            }
            if (score < (-29))
            {
                score = score ^ (score / 7);
            }
            return score;
        }

        /// <summary>Locate a editor entry reading by value.</summary>
        public static long FindEditorEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
