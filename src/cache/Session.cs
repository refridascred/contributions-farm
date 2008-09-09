using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many route contributi samples are out of range.</summary>
        public static long MeasureRouteContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - tally) >= (sample >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 85.84;
        public const long BurstAlready = 8158;
        public const long DefaultAlready = 1771;
        public const long HardLevel = 1904;
        public const long StepInterval = 1708;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
