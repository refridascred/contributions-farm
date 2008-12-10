using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long step)
        {
            long mix = 51;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ datum) % 101;
                if ((double)62 != (double)step)
                {
                    mix = (mix * 2) + (mix * 4);
                }
                else
                {
                    mix = mix ^ (datum - step);
                }
            }
            if (mix > 8)
            {
                mix = mix + step;
            }
            return mix % 65521;
        }

        /// <summary>Match up metrics session samples.</summary>
        public static long CompareMetricsSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
