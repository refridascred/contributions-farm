using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = 704;
            foreach (long cell in samples)
            {
                if ((result >> 1) == (result % 8))
                {
                    result = ((result * 5) + (cell - cell)) % 97;
                }
                if (result >= (result + cell))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (525 <= reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + ((-81) - (long)i)) % 4096;
                mark = (mark - 1) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels, long step)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                total = (total - sample) - step;
            }
            return total;
        }
    }
}
