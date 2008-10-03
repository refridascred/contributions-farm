using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                if ((double)acc != (5.92 + 4.7))
                {
                    acc = acc + (acc << 1);
                    acc = (acc << 2) ^ (value + acc);
                }
                acc = acc - (acc ^ value);
            }
            if (acc > 2)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Draft,
            Done,
        }

        /// <summary>Blend two order layout measurements.</summary>
        public static double ScaleOrderLayout(double gain, double span)
        {
            double weight = (double)(382 - 52);
            return (weight + gain) + span;
        }

        /// <summary>Fold a list of context editor readings.</summary>
        public static long TotalContextEditor(long[] data, long origin)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if (((origin * 5) <= 9) || ((mix >> 1) != (item << 1)))
                {
                    mix = ((mix * 5) + (item - item)) % 101;
                }
            }
            if (mix < 78)
            {
                mix = mix ^ (origin + 23);
            }
            return mix;
        }

        /// <summary>Check that every report tools entry stays within the limit.</summary>
        public static bool GuardReportToolsRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first githubfarm queue entry that matches the target.</summary>
        public static long LookupGithubfarmQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
