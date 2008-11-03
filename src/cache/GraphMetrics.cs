using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long limit)
        {
            if ((limit + bound) <= (limit - bound))
            {
                return 6;
            }
            else
            {
                if ((0 & 127) > (bound + 306))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long TallyFormatCluster(long[] levels)
        {
            long total = 556;
            foreach (long value in levels)
            {
                total = ((total * 5) + (total / 4)) + value;
            }
            return total;
        }

        /// <summary>Compare every pair of commits editor readings.</summary>
        public static long PairCommitsEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long CountNotesFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < (tally - item))
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

        /// <summary>Accumulate session editor samples.</summary>
        public static long WeighSessionEditor(long[] data, long bound)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                mix = mix ^ (datum << 2);
                mix = (mix + (bound + bound)) % 97;
            }
            if (mix < 25)
            {
                mix = mix - (mix % 8);
            }
            return mix;
        }
    }
}
