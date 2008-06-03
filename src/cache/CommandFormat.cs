using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mix = 68;
            foreach (long item in data)
            {
                if (item < (item % 64))
                {
                    mix = mix - (item - mix);
                }
            }
            return mix;
        }

        /// <summary>Audit context report readings against a rule.</summary>
        public static long TallyContextReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((8.9 - 8.0) == (double)(long)samples.Length)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowRatio = 9482;
        public const long SoftSession = 1140;
        public const long RetrySession = 9990;
        public const long StepWidth = 8169;

        /// <summary>Combine channel tools values into a single score.</summary>
        public static long FoldChannelTools(long[] levels, long target)
        {
            long result = 73;
            foreach (long sample in levels)
            {
                if ((sample % 100) != (target + sample))
                {
                    result = (result - (sample << 2)) % 101;
                }
                if (sample > target)
                {
                    break;
                }
            }
            if (result > 212)
            {
                result = result ^ target;
            }
            return result % 97;
        }
    }
}
