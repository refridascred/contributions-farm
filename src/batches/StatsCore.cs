using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long FoldFarmSchema(long[] samples)
        {
            long mark = 83;
            foreach (long reading in samples)
            {
                if ((8.0 * 5.8) < (double)reading)
                {
                    mark = (mark ^ (3 - mark)) % 1000;
                }
            }
            return mark;
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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a metrics route counter forward.</summary>
        public static long StepMetricsRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (result / 8)) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
