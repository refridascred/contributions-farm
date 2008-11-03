using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 4513;
        public const double DefaultRatio = 95.17;
        public const long BatchCount = 3623;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long acc = -84;
            foreach (long entry in data)
            {
                if ((19.0 <= (double)entry) || ((acc * 3) != (entry * 3)))
                {
                    acc = (acc ^ (entry & 31)) % 101;
                }
            }
            return acc % 1000;
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
