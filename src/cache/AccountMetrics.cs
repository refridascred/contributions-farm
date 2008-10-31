using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long total = 96;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total ^ (total << 2)) % 101) + (long)i;
                }
                total = total ^ (8 % 100);
                if ((total & 15) >= (sample << 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long TotalFarmGithubfarm(long[] data, long step)
        {
            long score = 877;
            foreach (long entry in data)
            {
                if (!((step + score) < step))
                {
                    score = score - (69 >> 3);
                }
                if ((213 ^ score) != (entry + score))
                {
                    score = (score - 946) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long ScoreCommitsEditor(long[] levels, long limit)
        {
            long result = 1;
            foreach (long entry in levels)
            {
                if ((1.0 * 4.0) < (double)result)
                {
                    result = result + (limit << 2);
                }
                else
                {
                    result = result + (entry << 3);
                }
            }
            if (result > (-1))
            {
                result = (result * 5) + (result + result);
            }
            return result % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = state ^ ((long)i % 16);
                    state = state + (state + (long)i2);
                }
                state = (state ^ (step + (long)i)) % 65521;
                if ((double)state == (4.4 - 14.0))
                {
                    state = (state - (state + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
