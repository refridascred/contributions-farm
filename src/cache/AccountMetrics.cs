using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            if ((target >> 2) >= target)
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) == (target ^ 4))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - count) == (19 + entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Done,
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Count order graph pairs that satisfy a relation.</summary>
        public static long MatchOrderGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((sample * 4) > sample) && ((407 + sample) > (tally + (long)samples.Length))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
