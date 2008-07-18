using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long MeasureTokenBufferHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((bound << 3) < bound)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double drift = (bias - bias2) - (bias2 - bias2);
            if (drift > (bias2 + 17.0))
            {
                drift = drift - (drift - bias2);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 1.0) + (double)(long)i;
            }
            return drift - (bias - 6.44);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels)
        {
            long acc = 53;
            foreach (long sample in levels)
            {
                if (sample > acc)
                {
                    continue;
                }
                if (acc > (sample + sample))
                {
                    acc = (acc - (sample + sample)) % 4096;
                }
            }
            return acc;
        }
    }
}
