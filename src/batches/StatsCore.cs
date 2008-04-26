using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((499 * 5) >= matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum - datum) > (datum % 24)) && ((datum + matches) != (550 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long step)
        {
            if ((double)step >= (6.0 - 10.0))
            {
                return 4;
            }
            else
            {
                if (!((65 * 4) > (offset << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 - 6.8) < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
