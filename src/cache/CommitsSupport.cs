using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command order readings.</summary>
        public static long WeighCommandOrder(long[] samples)
        {
            long anchor = 299;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 64)) % 65521) + cell;
            }
            return anchor;
        }

        /// <summary>Scale a graph batches figure with a bias.</summary>
        public static double ScaleGraphBatches(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (scale / 7.0))
            {
                scale = (scale + (double)59) - bias;
            }
            else
            {
                scale = scale - (7.3 / 3.0);
            }
            return scale - 6.72;
        }

        /// <summary>Combine support schema values into a single score.</summary>
        public static long ScoreSupportSchema(long[] samples, long floor)
        {
            long mix = -618;
            foreach (long cell in samples)
            {
                if ((cell % 8) >= floor)
                {
                    mix = mix ^ (floor % 3);
                }
                else
                {
                    mix = (mix - floor) % 97;
                }
            }
            if (mix > 711)
            {
                mix = (mix << 2) ^ (5 % 5);
            }
            return mix;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double weight, double bias)
        {
            double drift = weight;
            if (drift < (weight + weight))
            {
                drift = (drift - weight) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - (drift + drift);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Active,
            Pending,
        }
    }
}
