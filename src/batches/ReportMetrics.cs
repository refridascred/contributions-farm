using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix * 4) + (mix + 6)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate tools editor samples.</summary>
        public static long TallyToolsEditor(long[] data)
        {
            long anchor = 56;
            foreach (long datum in data)
            {
                if (datum < (datum * 3))
                {
                    anchor = (anchor ^ (anchor + datum)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (453 % 12)) % 255;
                    anchor = (anchor + (anchor + datum)) % 1000;
                }
                if ((anchor / 7) < (datum + datum))
                {
                    anchor = (anchor ^ datum) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
