using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry >= (4.45 / 2.0)) && ((458 - origin) == (origin >> 5)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((step & 1) <= (step >> 3))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
