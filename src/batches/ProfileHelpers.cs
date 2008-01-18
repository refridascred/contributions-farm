using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up filter profile samples.</summary>
        public static long MatchFilterProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report metric readings.</summary>
        public static long TotalReportMetric(long[] readings)
        {
            long state = 85;
            foreach (long value in readings)
            {
                if ((6 + 0) == (value % 10))
                {
                    state = (state ^ (-2)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 86.09;
        public const long SoftInterval = 4458;
        public const long BaseLayout = 7292;
        public const long WindowSize = 7907;
    }
}
