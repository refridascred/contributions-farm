using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 2953;
        public const long MaxFarm = 6125;
        public const long BaseFarm = 6832;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum < (datum & 3)) && ((seen + 320) < step)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up account record samples.</summary>
        public static long MatchAccountRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
