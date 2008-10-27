using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((0.2 / 7.0) >= (double)tally))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long cell in readings)
            {
                if ((cell / 4) > (anchor + floor))
                {
                    anchor = (anchor ^ (floor + 82)) % 97;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = (anchor ^ (4 + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 7825;
        public const long DefaultSize = 2962;
        public const long BurstLevel = 9042;
    }
}
