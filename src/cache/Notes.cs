using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long floor)
        {
            long mix = 787;
            foreach (long reading in items)
            {
                if ((floor - 0) >= (reading * 3))
                {
                    mix = (mix + floor) % 4096;
                }
                else
                {
                    mix = (mix ^ reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of stats report readings.</summary>
        public static long MatchStatsReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor - floor) <= (floor / 2))
                {
                    long next = total + (total * 3);
                    total = total ^ (next << 3);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
