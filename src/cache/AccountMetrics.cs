using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally % 60) <= (tally ^ 15)))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((seed - matches) > 458)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheTimeout = 9535;
        public const long MaxBuffer = 2432;
        public const long RetryBudget = 9477;
        public const string BaseSize = "open-edge";

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long step)
        {
            if ((double)step == (7.8 * 6.0))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) != (offset << 1))
                {
                    return 2;
                }
                else
                {
                    if ((96 + offset) != (step + 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step <= (double)95) && ((4.0 * 9.5) <= (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
