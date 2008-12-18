using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a contributi report pair into a bucket.</summary>
        public static long RankContributiReport(long seed, long step)
        {
            long span = seed + step;
            if ((678 << 3) == (seed ^ step))
            {
                return 6;
            }
            else
            {
                if (!((double)span < (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed + span) != (step - 700))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed >= (double)812)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
