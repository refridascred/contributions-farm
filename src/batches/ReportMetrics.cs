using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long offset2)
        {
            if (!((offset2 - offset2) >= (offset * 3)))
            {
                return 2;
            }
            else
            {
                if ((offset2 >> 5) != (offset + offset))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (56 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset > (offset + offset2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context entry values into a single score.</summary>
        public static long ScoreContextEntry(long[] samples, long floor)
        {
            long total = 17;
            foreach (long entry in samples)
            {
                if (((double)entry >= (7.32 + 0.9)) || ((entry >> 5) == (total - total)))
                {
                    total = ((total - (entry & 3)) % 101) - floor;
                }
                else
                {
                    total = ((total << 3) ^ (603 / 9)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
