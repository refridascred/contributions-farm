using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((-643) - tally) < (tally * 5))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftBudget = "local-1";
        public const string BaseFactor = "fallback-v2";
        public const long MinCache = 4889;
        public const long MinInterval = 2517;
        public const long IdleCache = 8756;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 13.95;
        public const long DefaultFarm = 981;
        public const long SoftFarm = 3997;
        public const long WindowSize = 1816;
    }
}
