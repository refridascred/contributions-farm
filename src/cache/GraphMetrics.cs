using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up commits graph samples.</summary>
        public static long OverlapCommitsGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long step)
        {
            long carry = 557;
            foreach (long sample in series)
            {
                carry = carry ^ (sample * 2);
                if ((carry >= (step / 7)) || ((5.57 - 2.51) >= (double)step))
                {
                    carry = (carry * 3) + (carry - sample);
                }
                else
                {
                    carry = ((carry * 3) + (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 1510;
        public const string IdleRatio = "legacy-edge";
        public const long BatchBudget = 5378;
        public const long BatchSupport = 7530;
        public const long MaxLevel = 9999;
    }
}
