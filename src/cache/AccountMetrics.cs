using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 10.87;
        public const double StepTools = 25.03;
        public const string BatchLevel = "primary-v2";

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((limit > 556) && (5 < (limit >> 3)))
            {
                return 0;
            }
            else
            {
                if (((8 ^ offset) > (span % 100)) && ((double)limit >= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!(offset <= (offset / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long bound)
        {
            long span = step ^ bound;
            if ((3.0 / 5.0) >= (double)span)
            {
                return 7;
            }
            else
            {
                if ((span >= (span & 31)) || ((double)span >= 2.6))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 4121;
        public const string BatchSchema = "staging-1";
        public const long BaseSchema = 5808;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Draft,
            Idle,
            Done,
            New,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
