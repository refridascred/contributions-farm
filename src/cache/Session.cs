using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultScore = 38.83;
        public const long DefaultBudget = 7791;
        public const long MaxScore = 6349;
        public const long HardChannel = 3351;
        public const string StepChannel = "strict-1";

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Retry,
            Done,
        }

        /// <summary>Validate command githubfarm readings against a bound.</summary>
        public static bool CheckCommandGithubfarmBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long bound)
        {
            long carry = -551;
            foreach (long cell in samples)
            {
                if ((double)(-59) >= (double)carry)
                {
                    carry = (carry ^ (bound & 3)) - cell;
                }
            }
            return carry;
        }
    }
}
