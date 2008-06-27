using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double drift = (scale / 3.0) / 7.0;
            if (drift > (span + scale))
            {
                drift = drift - span;
            }
            else
            {
                drift = drift - (double)767;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 250;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 3)) ^ sample;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 768;
        public const long DefaultTimeout = 9322;
        public const long WindowLayout = 5155;
        public const long StepLayout = 8079;
    }
}
