using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long limit)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if (!((carry + limit) > (value + carry)))
                {
                    carry = ((carry * 5) + (6 % 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 7052;
        public const double IdleSize = 28.38;
        public const long WindowContext = 8207;
        public const long StepInterval = 7349;

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long acc = 826;
            foreach (long sample in data)
            {
                acc = (acc << 2) ^ (acc - acc);
                if (!((acc + sample) == (593 * 4)))
                {
                    acc = (acc * 5) + (target + sample);
                }
            }
            if (acc > 178)
            {
                acc = acc ^ (target + target);
            }
            return acc % 4096;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Stale,
            Ready,
            Done,
        }
    }
}
