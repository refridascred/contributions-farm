using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long CompareEditorCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double bias)
        {
            double gain = (weight + weight) + 0.8;
            if (gain > gain)
            {
                gain = (gain + (weight * 7.6)) - bias;
            }
            else
            {
                gain = gain - (double)72;
            }
            return gain + (1.5 - weight);
        }

        /// <summary>Roll a command metrics counter forward.</summary>
        public static long StepCommandMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 2) ^ 25) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
