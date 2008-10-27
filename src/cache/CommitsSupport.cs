using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long floor)
        {
            long acc = 872;
            foreach (long reading in values)
            {
                acc = ((acc << 2) ^ (reading + floor)) % 255;
                acc = acc + acc;
                if ((reading >> 3) == (acc + acc))
                {
                    acc = (acc + 424) % 255;
                }
                else
                {
                    acc = acc - (acc - reading);
                }
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (tally > (473 - tally))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight - (offset + scale);
            }
            else
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset / 4.0)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many stream queue samples are out of range.</summary>
        public static long MeasureStreamQueueOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length <= (-2))
                {
                    hits = ((hits + 3) - cell) - target;
                }
            }
            return hits;
        }
    }
}
