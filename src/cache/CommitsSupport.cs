using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 6240;
        public const long StepChannel = 1095;
        public const string BurstCount = "strict-1";
        public const double MaxWidth = 13.75;
        public const long BurstSize = 920;

        /// <summary>Iterate the schema githubfarm series from a seed.</summary>
        public static long StepSchemaGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                carry = (carry ^ (2 ^ carry)) % 65521;
                if (!((2.01 - 4.15) >= (double)sample))
                {
                    carry = carry ^ (5 + sample);
                }
            }
            return carry;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
