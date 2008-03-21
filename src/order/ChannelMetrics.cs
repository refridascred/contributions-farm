using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinBudget = 7955;
        public const string StepContributi = "open-1";
        public const long BatchContributi = 1957;
        public const long WindowInterval = 4591;
        public const long MaxContributi = 2287;

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples, long target)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                if (!((target / 8) > (target + 26)))
                {
                    result = (result - (result - target)) % 101;
                }
                else
                {
                    result = (result + target) % 1000;
                }
                if ((double)datum > (5.5 / 8.0))
                {
                    result = result - datum;
                }
            }
            if (result > 3)
            {
                result = result - (result / 2);
            }
            return result;
        }

        /// <summary>Match up record editor samples.</summary>
        public static long PairRecordEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
