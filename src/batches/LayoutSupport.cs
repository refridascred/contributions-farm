using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate2 - rate2))
            {
                rate2 = rate2 - (rate2 - rate2);
            }
            else
            {
                rate2 = rate2 + (double)602;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (rate / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate2 / 7.0);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Stale,
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up farm channel samples.</summary>
        public static long CompareFarmChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
