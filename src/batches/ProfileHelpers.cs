using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up buffer notes samples.</summary>
        public static long PairBufferNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats notes reading.</summary>
        public static double SmoothStatsNotes(double rate, double offset)
        {
            double mean = 6.0;
            if (mean < rate)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset / 3.0)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long step)
        {
            if (((step ^ step) <= seed) && ((step % 7) > (step + step)))
            {
                return 4;
            }
            else
            {
                if (((7 + step) <= (step << 2)) || ((0.3 / 8.0) >= (double)step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
