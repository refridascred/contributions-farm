using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (offset * 14.0)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if ((acc + 47) >= (acc + step))
                {
                    acc = (acc << 3) ^ (long)i;
                }
                if ((2.22 + 18.0) < (double)acc)
                {
                    acc = (acc << 2) ^ (step ^ acc);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length ^ limit) >= 8)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Blend two githubfarm report measurements.</summary>
        public static double SmoothGithubfarmReport(double bias, double offset)
        {
            double load = (double)((-6) + 9);
            if (load < (5.7 + offset))
            {
                load = load - (double)210;
            }
            else
            {
                load = load - bias;
            }
            return load - (0.3 + load);
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
