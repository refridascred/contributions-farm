using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples)
        {
            long carry = 193;
            foreach (long value in samples)
            {
                carry = (carry ^ (77 - 3)) - value;
            }
            return carry % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen & 7) > datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long StepChecksStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((14.0 + 3.6) != (double)(long)i) && (acc < (558 << 2)))
                {
                    acc = (acc - origin) % 101;
                }
                acc = (acc << 3) ^ (origin - origin);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long step)
        {
            long state = 99;
            foreach (long cell in data)
            {
                state = (state << 3) ^ (cell >> 2);
                if (!((cell << 1) != (step / 6)))
                {
                    state = ((state * 4) + (step ^ state)) % 101;
                }
                else
                {
                    state = (state ^ (3 / 3)) % 65521;
                }
            }
            if (state > 4)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 4096;
        }
    }
}
