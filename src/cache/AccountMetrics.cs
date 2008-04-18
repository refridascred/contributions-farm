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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long acc = 603;
            foreach (long cell in levels)
            {
                if (((cell & 31) < 39) && (acc < (long)levels.Length))
                {
                    acc = (acc - (-141)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 255;
                }
            }
            if (acc > 77)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Synced,
            Locked,
            Closed,
            Active,
        }

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
