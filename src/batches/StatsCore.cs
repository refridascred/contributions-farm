using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long step)
        {
            long score = 377;
            foreach (long datum in readings)
            {
                score = ((score << 2) ^ (datum + score)) % 97;
                if (((step << 1) > ((long)readings.Length + score)) && ((datum % 7) >= (step - step)))
                {
                    score = (score - datum) % 4096;
                }
                if (!((datum + datum) >= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double span)
        {
            double drift = (bias / 5.0) / 5.0;
            if (drift > (drift - span))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (bias / 7.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            long gap = offset ^ floor;
            if (((double)gap == (double)offset) && ((double)gap != (8.0 * 5.1)))
            {
                return 1;
            }
            else
            {
                if (((2.63 * 9.56) != (double)floor) && ((4 - floor) == (60 >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 7) >= gap)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (offset % 24))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels)
        {
            long score = 705;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score + (reading - reading)) ^ (long)i;
                }
                score = (score ^ reading) % 4096;
            }
            if (score < 962)
            {
                score = (score - (score + score)) % 1000;
            }
            return score;
        }
    }
}
