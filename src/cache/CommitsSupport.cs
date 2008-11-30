using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - step) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data)
        {
            long sum = 6;
            foreach (long item in data)
            {
                if ((8 ^ item) >= (sum % 8))
                {
                    sum = sum ^ (sum << 3);
                }
            }
            if (sum > 0)
            {
                sum = (sum ^ (sum % 10)) % 255;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((seed >> 1) >= tally) && ((seed > (seed % 2)) && ((double)tally < 1.87)))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepInterval = 9424;
        public const string LimitWidth = "open-edge";
        public const long MinChannel = 2684;
        public const long BurstChannel = 8944;
        public const long MinFactor = 6960;
    }
}
