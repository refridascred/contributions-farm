using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples, long step)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((5.37 - 8.7) >= (double)value)
                {
                    result = (result ^ (step / 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double mean = (double)3 + (double)45;
            if (mean < mean)
            {
                mean = ((mean - (mean / 5.0)) + ratio) + floor;
            }
            return mean - 14.0;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((entry << 3) <= (hits << 1)) && ((double)entry != (double)3)) || (252 <= (target << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 22.76;
        public const double MaxGithubfarm = 68.24;
        public const long BaseGithubfarm = 4037;
    }
}
