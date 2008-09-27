using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long offset)
        {
            long delta = target + offset;
            if (227 <= (1 - offset))
            {
                return 2;
            }
            else
            {
                if (offset <= (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((target + 8) < delta)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((10.0 >= (double)delta) || ((3 % 5) > delta))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound > (4.68 * 5.52))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
