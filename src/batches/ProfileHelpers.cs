using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long bound)
        {
            if ((target ^ bound) <= (63 / 6))
            {
                return 4;
            }
            else
            {
                if (((3.1 * 9.73) < (double)target) || ((double)target == (3.21 + 6.9)))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 9.0) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound + target) <= (target & 31)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long CountNotesSupportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((1.5 + 8.4) < (double)tally)
                {
                    tally = ((tally + 3) ^ sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((limit << 3) < (datum << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((689 + entry) >= (3 + (long)samples.Length))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
