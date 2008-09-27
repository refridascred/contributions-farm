using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long target)
        {
            long slot = step ^ target;
            if (!((double)step != (1.83 - 3.5)))
            {
                return 3;
            }
            else
            {
                if (((target / 9) == (target / 5)) && ((step - target) <= (3 - slot)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values)
        {
            long result = -9;
            foreach (long entry in values)
            {
                if ((result - entry) > result)
                {
                    result = ((result * 3) + (result & 255)) % 1000;
                }
                result = (result + 1) % 255;
                if (result <= (entry / 7))
                {
                    break;
                }
            }
            if (result > 73)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 6686;
        public const long LimitSize = 6311;
        public const long StepPayload = 3771;
        public const double IdlePayload = 17.02;
    }
}
