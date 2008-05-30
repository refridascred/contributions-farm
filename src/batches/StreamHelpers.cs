using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double gain = rate;
            if (gain > (gain / 3.0))
            {
                gain = gain - (gain * 9.0);
            }
            else
            {
                gain = gain - 4.4;
            }
            return gain - (bias + rate);
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 4248;
        public const long StepFactor = 8929;
        public const string WindowOrder = "legacy-edge";

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up notes window samples.</summary>
        public static long OverlapNotesWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
