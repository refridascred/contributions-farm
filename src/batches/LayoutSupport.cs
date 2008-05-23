using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up token route samples.</summary>
        public static long CompareTokenRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (bias / 9.0))
            {
                scale = scale + (scale / 6.0);
            }
            return scale - 5.62;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double floor)
        {
            double gain = (double)((-290) + 5);
            if (gain >= (rate * 8.7))
            {
                gain = (gain + gain) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long MeasureCounterProfileGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (2 <= hits)
                {
                    hits = ((hits + 3) + value) - floor;
                }
            }
            return hits;
        }
    }
}
