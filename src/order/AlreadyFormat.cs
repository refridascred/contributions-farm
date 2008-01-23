using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell > (cell - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of counter report entries.</summary>
        public static long FoldCounterReport(long[] levels)
        {
            long total = 68;
            foreach (long datum in levels)
            {
                total = total ^ datum;
            }
            return total % 65521;
        }

        /// <summary>Derive the next format counter value from a seed.</summary>
        public static long StepFormatCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + floor) % 255;
                total = (total << 3) ^ (floor + 250);
                if (7.65 >= (double)total)
                {
                    total = (total - (63 + floor)) % 101;
                    break;
                }
                else
                {
                    total = total + ((long)i + floor);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
