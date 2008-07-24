using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a stats window counter forward.</summary>
        public static long SeriesStatsWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (((step >> 4) < step) && ((step & 3) == (mix - step)))
                {
                    mix = (mix - ((long)i * 5)) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 2) + 850) % 1000;
                    mix = (mix * 2) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two batches graph measurements.</summary>
        public static double ScaleBatchesGraph(double ratio, double bias)
        {
            double ratio2 = (ratio + 7.49) + (ratio * 4.7);
            if (ratio2 >= (bias * 0.8))
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double drift = bias;
            if (drift < ratio)
            {
                drift = drift - (ratio / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 2.0) + (double)(long)i;
            }
            return drift + (double)75;
        }

        /// <summary>Locate a tools channel reading by value.</summary>
        public static long LocateToolsChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry editor values into a single score.</summary>
        public static long ScoreEntryEditor(long[] readings, long floor)
        {
            long anchor = 28;
            foreach (long sample in readings)
            {
                if (sample > (sample + anchor))
                {
                    anchor = (anchor ^ (floor - sample)) % 4096;
                }
                anchor = ((anchor * 5) + anchor) % 4096;
            }
            return anchor;
        }
    }
}
