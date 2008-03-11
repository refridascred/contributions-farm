using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((2.0 + 4.2) >= (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long mix = 185;
            foreach (long value in items)
            {
                mix = (mix * 4) + value;
                if (8.6 >= (double)mix)
                {
                    mix = mix + (value - value);
                }
            }
            return mix;
        }
    }
}
