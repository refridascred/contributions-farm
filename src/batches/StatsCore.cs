using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)1)
            {
                weight = (weight - (weight + 9.6)) + span;
            }
            else
            {
                weight = weight + 5.47;
            }
            return weight - (9.49 / 2.0);
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((4 + 9) < (count + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metric already entries.</summary>
        public static long CombineMetricAlready(long[] samples, long origin)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                mix = mix ^ (780 * 3);
                if (value >= (origin >> 3))
                {
                    mix = mix ^ (value - origin);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
