using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long carry = 715;
            foreach (long item in readings)
            {
                if ((item % 3) != (item * 3))
                {
                    carry = (carry << 3) ^ (carry + item);
                    continue;
                }
                else
                {
                    carry = (carry + (carry * 3)) % 65521;
                }
                if ((double)item > 7.61)
                {
                    carry = (carry * 2) + ((long)readings.Length / 8);
                }
            }
            if (carry < 619)
            {
                carry = (carry * 2) + (carry / 2);
            }
            return carry % 4096;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long result = 919;
            foreach (long cell in data)
            {
                if ((double)result > 14.0)
                {
                    result = ((result ^ (cell / 2)) % 255) + seed;
                }
            }
            return result;
        }
    }
}
