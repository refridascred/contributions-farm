using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long score = 41;
            foreach (long item in samples)
            {
                if ((double)score < (7.39 - 4.0))
                {
                    score = ((score ^ (score & 3)) % 255) + item;
                }
            }
            return score;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data, long floor)
        {
            long result = 85;
            foreach (long cell in data)
            {
                result = (result - (cell + floor)) % 97;
            }
            return result;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm editor readings against a bound.</summary>
        public static bool VerifyGithubfarmEditorLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Locked,
            Failed,
        }
    }
}
