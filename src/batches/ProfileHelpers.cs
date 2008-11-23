using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count profile githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapProfileGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long total = 53;
            foreach (long entry in samples)
            {
                total = ((total * 3) + (seed * 4)) % 97;
                if (((total - seed) <= (total - entry)) || ((entry >> 2) > (4 % 3)))
                {
                    break;
                }
            }
            if (total > 647)
            {
                total = (total - (seed % 3)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (limit >> 3)) % 1000;
                if (!((4.0 - 7.4) != (double)(long)i))
                {
                    total = total ^ (total % 7);
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
